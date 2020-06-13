using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Order = Banana_E_Commerce_API.Entities.Order;
using OrderItem = Banana_E_Commerce_API.Entities.OrderItem;

namespace Banana_E_Commerce_API.Services
{
    public interface IOrderService
    {
        Task<CreateResult<Order>> CreateAsync(
            Order order,
            int requestedUserId,
            string stripeSecretKey);
        Task<Order> GetByIdAsync(
            int id,
            int requestedUserId);
        Task<Order> GetByIdAsyncAnonymous(
            int id);
        Task<Order> GetByPaymentIntentIdAsync(
            string paymentIntentId);
        Task<IEnumerable<Order>> GetAllAsync(
            PaginationFilter pagination,
            GetAllOrdersFilter filter,
            int requestedUserId);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllOrdersFilter filter,
            int requestedUserId);
        Task<UpdateResult<Order>> HandOverOrderToStorageManager(Order order);
        Task<UpdateResult<Order>> CancelOrderAsync(
            Order order,
            CancelOrderReport cancelOrderReport);
        Task<bool> ChangeOrderToPayed(Order order);
        Task<UpdateResult<Order>> ChangeOrderToSucceeded(Order order);
    }

    public class OrderService : IOrderService
    {
        private readonly DataContext _context;
        private readonly IUserService _userService;
        private readonly IEmailTemplateService _emailTemplateService;
        private readonly IEmailService _emailService;

        public OrderService(
            DataContext context,
            IUserService userService,
            IEmailTemplateService emailTemplateService,
            IEmailService emailService
        )
        {
            _context = context;
            _userService = userService;
            _emailTemplateService = emailTemplateService;
            _emailService = emailService;
        }

        /** CREATE ASYNC */
        public async Task<CreateResult<Order>> CreateAsync(
            Order order,
            int requestedUserId,
            string stripeSecretKey)
        {
            var customer = await _context.Customers
                .Where(c => c.UserId == requestedUserId)
                .Include(c => c.Cart)
                .Include(c => c.User)
                .FirstOrDefaultAsync();
            var chosenPaymentMethod = await _context.PaymentMethods
                .SingleOrDefaultAsync(x => x.Id == order.PaymentMethodId);

            /** Get all products in cart of customer to create order */
            var cartDetails = await GetListCartDetailToPay(customer.Cart.Id);
            if (cartDetails.Count() == 0)
            {
                return new CreateResult<Order>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Bạn không có sản phẩm trong giỏ hàng để thanh toán"
                    }
                };
            }

            /** Get all product tiers in order items from db to use */
            var productTiers = await GetListProductTierFromCartDetails(cartDetails);

            List<OrderItem> orderItems = CreateListOrderItemFromProductsInCart(
                cartDetails,
                productTiers
            );

            PrepareOrderInfo(
                order,
                orderItems,
                productTiers,
                customer.Id);

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    /** Handle stripe payment (if choose) */
                    HandleStripePaymentIfPaymentMethodIsStripe(
                        chosenPaymentMethod,
                        order,
                        stripeSecretKey
                    );

                    /** Create order */
                    await _context.Orders.AddAsync(order);
                    var orderCreated = await _context.SaveChangesAsync();
                    if (!(orderCreated > 0))
                    {
                        transaction.Dispose();
                        throw new Exception("Thanh toán giỏ hàng thất bại, xin thử lại");
                    }

                    /** Create order items */
                    bool isCreateOrderItemsSuccess = await CreateOrderItemsOfOrder(
                        orderItems,
                        order,
                        productTiers
                    );
                    if (!isCreateOrderItemsSuccess)
                    {
                        transaction.Dispose();
                        throw new Exception("Thanh toán giỏ hàng thất bại, xin thử lại");
                    }

                    /** Clear all cart items after pay cart (after create order) */
                    var areAllCartDetailsCleared = await ClearAllCartItemsAfterPayCart(
                        cartDetails
                    );
                    if (!areAllCartDetailsCleared)
                    {
                        transaction.Dispose();
                        throw new Exception("Thanh toán giỏ hàng thất bại, xin thử lại");
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    return new CreateResult<Order>
                    {
                        IsSuccess = false,
                        Errors = new List<string>()
                        {
                            e.Message.ToString()
                        }
                    };
                }
            }

            /** Send mail to user */
            string orderMailTemplate = _emailTemplateService
                .CreateOrderHtmlTempalteToSendMailToCustomer(
                    order.Code,
                    order.TotalAmount,
                    order.CreatedAt,
                    orderItems,
                    productTiers,
                    customer.Name,
                    customer.User.Email
                );
            _emailService.SendMail(
                customer.User.Email,
                customer.Name,
                $"Đơn hàng của khách hàng '{customer.Name}' vào {order.CreatedAt.ToString("dd/MM/y yyy HH:mm:ss")}",
                orderMailTemplate
            );

            return new CreateResult<Order>
            {
                IsSuccess = true,
                EntityReturn = order
            };
        }

        private async Task<IEnumerable<CartDetail>> GetListCartDetailToPay(
            int cartId
        )
        {
            return await _context.CartDetails
                .Where(cd => cd.CartId == cartId)
                .ToListAsync();
        }

        private List<OrderItem> CreateListOrderItemFromProductsInCart(
            IEnumerable<CartDetail> cartDetails,
            IEnumerable<ProductTier> productTiers
        )
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (var cartDetail in cartDetails)
            {
                var productTier = productTiers
                    .SingleOrDefault(pt => pt.Id == cartDetail.ProductTierId);

                OrderItem orderItem = new OrderItem
                {
                    Quantity = cartDetail.Quantity,
                    SinglePrice = productTier.PricePerKg,
                    ProductTierId = cartDetail.ProductTierId,
                };

                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        private async Task<IEnumerable<ProductTier>> GetListProductTierFromCartDetails(
            IEnumerable<CartDetail> cartDetails
        )
        {
            var productTierIdsInCartDetails = cartDetails.Select(x => x.ProductTierId);
            var productTiers = await _context.ProductTiers
                .Where(x => productTierIdsInCartDetails.Contains(x.Id) &&
                    x.IsDeleted == false)
                .Include(pt => pt.Product)
                .Include(pt => pt.Tier)
                .ToListAsync();

            return productTiers;
        }

        private void PrepareOrderInfo(
            Order order,
            IEnumerable<OrderItem> orderItems,
            IEnumerable<ProductTier> productTiers,
            int customerId
        )
        {
            order.OrderStatus = OrderStatus.New;
            order.IsPayed = false;
            order.TotalAmount = CalculateOrderTotalAmount(orderItems, productTiers);
            order.Currency = PriceCurrency.VND;
            order.Code = Regex.Replace(
                Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");
            order.IsCustomerReceive = false;
            order.IsDeleted = false;
            order.CreatedAt = DateTime.UtcNow;
            order.UpdatedAt = DateTime.UtcNow;
            order.CustomerId = customerId;

        }

        private double CalculateOrderTotalAmount(
            IEnumerable<OrderItem> orderItems,
            IEnumerable<ProductTier> productTiers
        )
        {
            double totalAmount = 0;
            foreach (var item in orderItems)
            {
                var productTier = productTiers.SingleOrDefault(x => x.Id == item.ProductTierId);

                double totalPriceOfItem = item.Quantity * productTier.PricePerKg;
                totalAmount += totalPriceOfItem;
            }

            return totalAmount;
        }

        private async Task<bool> CreateOrderItemsOfOrder(
            IEnumerable<OrderItem> orderItems,
            Order order,
            IEnumerable<ProductTier> productTiers
        )
        {
            var checkValidOrderItemsResult = CheckValidOrderItems(
                orderItems,
                productTiers);
            if (checkValidOrderItemsResult.IsSuccess == false)
            {
                throw new Exception("Danh sách sản phẩm trong đơn hàng không hợp lệ");
            }

            /** Add the rest info to each order item */
            orderItems = orderItems.Select(item =>
            {
                // get product tier to get current price
                var productTier = productTiers
                    .SingleOrDefault(x => x.Id == item.ProductTierId);

                item.OrderId = order.Id;
                item.SinglePrice = productTier.PricePerKg;

                return item;
            });

            await _context.OrderItems.AddRangeAsync(orderItems);
            var created = await _context.SaveChangesAsync();

            return created > 0;
        }

        private CheckValidResult CheckValidOrderItems(
            IEnumerable<OrderItem> orderItems,
            IEnumerable<ProductTier> productTiers
        )
        {
            /**
             * if two list has the same length that's mean all product tiers in order items valid */
            if (productTiers.Count() != orderItems.Count())
            {
                return new CheckValidResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Danh sách sản phẩm trong đơn hàng không hợp lệ"
                    }
                };
            }

            /** Only can order product which staus is NewGoodsImported or Stocking */
            bool isValid = true;
            foreach (var item in orderItems)
            {
                var productTier = productTiers
                    .SingleOrDefault(pt => pt.Id == item.ProductTierId);
                if (productTier.Product.Status == ProductStatus.OutOfStock)
                {
                    isValid = false;
                }
            }

            return new CheckValidResult
            {
                IsSuccess = isValid
            };
        }

        private async Task<bool> ClearAllCartItemsAfterPayCart(
            IEnumerable<CartDetail> cartDetails
        )
        {
            _context.CartDetails.RemoveRange(cartDetails);
            var deleted = await _context.SaveChangesAsync();

            return deleted > 0;
        }

        private void HandleStripePaymentIfPaymentMethodIsStripe(
            Entities.PaymentMethod chosenPaymentMethod,
            Order order,
            string stripeSecretKey
        )
        {
            if (chosenPaymentMethod.Method == MethodOfPayment.Stripe)
            {
                /** If payment by Stripe */
                StripeConfiguration.ApiKey = stripeSecretKey;

                var options = new PaymentIntentCreateOptions
                {
                    Amount = (long?)order.TotalAmount,
                    Currency = "vnd",
                };
                var stripeService = new PaymentIntentService();
                var paymentIntent = stripeService.Create(options);
                order.PaymentIntentId = paymentIntent.Id;
                order.StripeClientSecret = paymentIntent.ClientSecret;
            }
        }


        /** GET BY ID ASYNC */
        public async Task<Order> GetByIdAsync(
            int id,
            int requestedUserId)
        {
            var user = await _userService.GetByIdAsync(requestedUserId);

            var queryable = _context.Orders.AsQueryable();

            /** If role is customer, then just get only order of that customer */
            if (user.Role.RoleName == RoleNameEnum.Customer)
            {
                queryable = queryable.Where(o => o.CustomerId == user.Customer.Id);
            }

            return await queryable
                .Where(o => o.Id == id)
                    .Include(o => o.OrderItems)
                        .ThenInclude(oi => oi.ProductTier)
                            .ThenInclude(pt => pt.Product)
                                .ThenInclude(p => p.ProductImages)
                    .Include(o => o.Address)
                    .Include(o => o.PaymentMethod)
                .FirstOrDefaultAsync();
        }


        /** GET ALL ASYNC */
        public async Task<IEnumerable<Order>> GetAllAsync(
            PaginationFilter pagination,
            GetAllOrdersFilter filter,
            int requestedUserId)
        {
            var queryable = _context.Orders.AsQueryable();

            queryable = await AddFilterOnQuery(filter, queryable, requestedUserId);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Skip(skip)
                .Take(pagination.PageSize)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.ProductTier)
                        .ThenInclude(pt => pt.Product)
                            .ThenInclude(p => p.ProductImages)
                .Include(o => o.Address)
                .Include(o => o.PaymentMethod)
                .ToListAsync();
        }

        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllOrdersFilter filter,
            int requestedUserId)
        {
            var queryable = _context.Orders.AsQueryable();

            queryable = await AddFilterOnQuery(filter, queryable, requestedUserId);
            return await queryable.CountAsync();
        }

        private async Task<IQueryable<Order>> AddFilterOnQuery(
            GetAllOrdersFilter filter,
            IQueryable<Order> queryable,
            int requestedUserId
        )
        {
            var user = await _userService.GetByIdAsync(requestedUserId);

            /** If role is customer, then just get only order of that customer */
            if (user.Role.RoleName == RoleNameEnum.Customer)
            {
                queryable = queryable.Where(o => o.CustomerId == user.Customer.Id);
            }

            /** If role is storage manager then can't see canceled order */
            if (user.Role.RoleName == RoleNameEnum.StorageManager)
            {
                queryable = queryable.Where(o => o.OrderStatus != OrderStatus.Canceled &&
                    o.OrderStatus != OrderStatus.New);
            }

            queryable = queryable.Where(x => x.IsDeleted == false);

            if (!string.IsNullOrEmpty(filter?.Code))
            {
                queryable = queryable.Where(x => x.Code.Contains(filter.Code));
            }

            if (!string.IsNullOrEmpty(filter?.FromCreatedAt))
            {
                try
                {
                    var fromCreatedAtDate = DateTime
                    .ParseExact(filter?.FromCreatedAt, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    queryable = queryable.Where(x => x.CreatedAt >= fromCreatedAtDate);
                }
                catch
                {
                }
            }
            if (!string.IsNullOrEmpty(filter?.ToCreatedAt))
            {
                try
                {
                    var toCreatedAtDate = DateTime
                    .ParseExact(filter?.ToCreatedAt, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    queryable = queryable.Where(x => x.CreatedAt <= toCreatedAtDate);
                }
                catch
                { }
            }

            if (!string.IsNullOrEmpty(filter?.Notes))
            {
                queryable = queryable.Where(x => x.Notes.Contains(filter.Notes));
            }

            // filter by total amount
            if (filter?.FromAmount != null)
            {
                queryable = queryable.Where(x => x.TotalAmount >= filter.FromAmount);
            }
            if (filter?.ToAmount != null && filter.ToAmount > 0)
            {
                queryable = queryable.Where(x => x.TotalAmount <= filter.ToAmount);
            }

            // filter by CreatedAt date
            // if (filter?.FromCreatedDate != null)
            // {
            //     queryable = queryable.Where(x => x.CreatedAt >= filter.FromCreatedDate);
            // }
            // if (filter?.ToCreatedDate != null)
            // {
            //     queryable = queryable.Where(x => x.CreatedAt <= filter.ToCreatedDate);
            // }

            if (filter?.IsGift != null && filter?.IsGift != BooleanSearch.All)
            {
                bool boolValue = filter.IsGift == BooleanSearch.True
                    ? true
                    : false;
                queryable = queryable.Where(x => x.IsGift == boolValue);
            }

            if (filter?.IsCustomerReceive != null &&
                user.Role.RoleName == RoleNameEnum.Admin &&
                filter?.IsGift != BooleanSearch.All)
            {
                bool boolValue = filter.IsCustomerReceive == BooleanSearch.True
                    ? true
                    : false;
                queryable = queryable.Where(x => x.IsCustomerReceive == boolValue);
            }

            if (filter?.CustomerId != null &&
                filter?.CustomerId != 0 &&
                user.Role.RoleName == RoleNameEnum.Admin)
            {
                queryable = queryable.Where(x => x.CustomerId == filter.CustomerId);
            }

            if (filter?.MethodOfPayment != null && filter?.MethodOfPayment != 0)
            {
                queryable = queryable.Where(x =>
                    x.PaymentMethod.Method == filter.MethodOfPayment);
            }

            if (filter?.OrderStatus != null && filter?.OrderStatus != 0)
            {
                queryable = queryable.Where(x =>
                    x.OrderStatus == filter.OrderStatus);
            }

            return queryable;
        }


        /** HAND OVER ORDER TO STORAGE MANAGER */
        public async Task<UpdateResult<Order>> HandOverOrderToStorageManager(Order order)
        {
            /** Only change order status to processing with the current status is New */
            if (order.OrderStatus != OrderStatus.New)
            {
                return new UpdateResult<Order>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Chỉ có thể bàn giao những đơn hàng mới tạo (trạng thái = New)"
                    }
                };
            }

            /** Change status to Processing */
            order.OrderStatus = OrderStatus.Processing;

            _context.Orders.Update(order);
            var updated = await _context.SaveChangesAsync();

            bool isUpdateSucceeded = updated > 0;

            if (!isUpdateSucceeded)
            {
                return new UpdateResult<Order>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Bàn giao hoá đơn bị lỗi, xin thử lại"
                    }
                };
            }

            return new UpdateResult<Order>
            {
                IsSuccess = true
            };
        }

        /** CANCLE ORDER ASYNC */
        public async Task<UpdateResult<Order>> CancelOrderAsync(
            Order order,
            CancelOrderReport cancelOrderReport)
        {
            var customer = await _context.Customers
                .Where(c => c.Id == order.CustomerId)
                .Include(c => c.User)
                .FirstOrDefaultAsync();

            try
            {
                if (!CheckValidCanceledOrder(order))
                {
                    throw new Exception("Huỷ đơn hàng bị lỗi, xin thử lại");
                }

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        /** Update status of order to Canceled */
                        order.OrderStatus = OrderStatus.Canceled;
                        _context.Orders.Update(order);
                        var updated = await _context.SaveChangesAsync();
                        if (!(updated > 0))
                        {
                            transaction.Dispose();
                            return new UpdateResult<Order>
                            {
                                IsSuccess = false,
                                Errors = new List<string>()
                                {
                                    "Huỷ hoá đơn không thành công, xin thử lại"
                                }
                            };
                        }

                        /** Create CancelOrderReport */
                        cancelOrderReport.OrderId = order.Id;
                        cancelOrderReport.CreatedAt = DateTime.UtcNow;
                        cancelOrderReport.IsDeleted = false;
                        await _context.CancelOrderReports.AddAsync(cancelOrderReport);
                        var created = await _context.SaveChangesAsync();
                        if (!(created > 0))
                        {
                            transaction.Dispose();
                            return new UpdateResult<Order>
                            {
                                IsSuccess = false,
                                Errors = new List<string>()
                                {
                                    "Huỷ hoá đơn không thành công, xin thử lại"
                                }
                            };
                        }

                        await transaction.CommitAsync();
                    }
                    catch (Exception e)
                    {
                        return new UpdateResult<Order>
                        {
                            IsSuccess = false,
                            Errors = new List<string>()
                        {
                            e.Message.ToString()
                        }
                        };
                    }
                }

            }
            catch (Exception e)
            {
                return new UpdateResult<Order>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        e.Message.ToString()
                    }
                };
            }

            /** Send mail to customer */
            string cancelOrderTemplate = _emailTemplateService
                .CancelOrderTemplate(
                    customer.Name,
                    order.Code,
                    cancelOrderReport.CancelReason
                );
            _emailService.SendMail(
                customer.User.Email,
                customer.Name,
                $"Huỷ hoá đơn {order.Code} tại Banana Boys Fruit",
                cancelOrderTemplate
            );

            return new UpdateResult<Order>
            {
                IsSuccess = true
            };

        }

        private bool CheckValidCanceledOrder(Order order)
        {
            /** Only can cancel order when its status is New */
            if (order.OrderStatus != OrderStatus.New)
            {
                throw new Exception("Chỉ được phép huỷ đơn hàng khi đơn hàng đó chưa bàn giao cho thủ kho (trạng thái = New)");
            }

            return true;
        }



        /** ChangeOrderStatusToPayed */
        public async Task<bool> ChangeOrderToPayed(Order order)
        {
            order.IsPayed = true;
            _context.Orders
                .Update(order);
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }



        /** GetByPaymentIntentIdAsync */
        public async Task<Order> GetByPaymentIntentIdAsync(string paymentIntentId)
        {
            return await _context.Orders
                .SingleOrDefaultAsync(x => x.PaymentIntentId == paymentIntentId);
        }


        /** GetByIdAsyncAnonymous */
        public async Task<Order> GetByIdAsyncAnonymous(int id)
        {
            return await _context.Orders
                .SingleOrDefaultAsync(x => x.Id == id);
        }



        /** CHANGE ORDER TO SUCCEEDED */
        public async Task<UpdateResult<Order>> ChangeOrderToSucceeded(Order order)
        {
            if (order.OrderStatus != OrderStatus.Delivering)
            {
                return new UpdateResult<Order>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Đơn hàng chưa thể hoàn thành vì chưa được giao"
                    }
                };
            }

            /** Update order status */
            order.OrderStatus = OrderStatus.Succeeded;

            /** IF payment is COD then update IsPayed to true */
            if (order.PaymentMethod.Method == MethodOfPayment.COD)
            {
                order.IsPayed = true;
            }

            _context.Orders
                    .Update(order);
            var updated = await _context.SaveChangesAsync();

            if (!(updated > 0))
            {
                return new UpdateResult<Order>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Xác nhận đơn hàng thành công có lỗi, xin thử lại"
                    }
                };
            }

            return new UpdateResult<Order>
            {
                IsSuccess = true
            };
        }
    }
}
