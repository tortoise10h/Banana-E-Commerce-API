using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.CartDetailModels;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface ICartDetailService
    {
        Task<AddToCartResult> AddProductToCartAsync(CartDetail cartDetail);
        Task<UpdateCartDetailResult> UpdateAsync(CartDetail cartDetail);
        Task<bool> DeleteAsync(int cartDetailId);
        Task<CartDetail> GetByIdAsync(int cartDetailId);
        Task<IEnumerable<CartDetail>> GetAllAsync(
            PaginationFilter pagination,
            GetAllCartDetailsFilter filter = null);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllCartDetailsFilter filter = null
        );
        Task<bool> DeleteAllAsync(int requestedUserId);
    }

    public class CartDetailService : ICartDetailService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CartDetailService(
            DataContext context,
            IMapper mapper
        )
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<AddToCartResult> AddProductToCartAsync(CartDetail cartDetail)
        {
            cartDetail.CreatedAt = DateTime.UtcNow;
            cartDetail.UpdatedAt = DateTime.UtcNow;

            // check product exists
            var productTier = await _context.ProductTiers
                .SingleOrDefaultAsync(p =>
                    p.Id == cartDetail.ProductTierId &&
                    p.IsDeleted == false);
            if (productTier == null)
            {
                return new AddToCartResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Sản phẩm này không tồn tại" }
                };
            }

            // check cart exists
            var cart = await _context.Carts
                .SingleOrDefaultAsync(c =>
                    c.Id == cartDetail.CartId);
            if (cart == null)
            {
                return new AddToCartResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Giỏ hàng của khách hàng không tồn tại" }
                };
            }

            // validate valid quantity
            if (cartDetail.Quantity > productTier.Quantity)
            {
                return new AddToCartResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Số lượng hiện tại của sản phẩm không đủ" }
                };
            }

            /** If new item has productId and cartId match the existing item
            * then update the quantity of the old item instead of create the new item
            */
            var handleAddExistedItemResult = await handleAddExistedItem(cartDetail, productTier);
            if (handleAddExistedItemResult != null)
            {
                /** Get created cart detail again include full product information
                * for FE to display in cart 
                */
                var detailAndFullProductInfo = await _context.CartDetails
                    .Where(cd => cd.Id == handleAddExistedItemResult.Id)
                    .Include(cd => cd.ProductTier)
                        .ThenInclude(pt => pt.Product)
                    .FirstOrDefaultAsync();
                return new AddToCartResult
                {
                    IsSuccess = true,
                    CartDetail = detailAndFullProductInfo
                };
            }


            await _context.CartDetails.AddAsync(cartDetail);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new AddToCartResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Thêm sản phẩm vào giỏ thất bại" }
                };
            }

            /** Get created cart detail again include full product information
             * for FE to display in cart 
             */
            var createdCartDetailAndProductInfo = await _context.CartDetails
                .Where(cd => cd.Id == cartDetail.Id)
                .Include(cd => cd.ProductTier)
                    .ThenInclude(pt => pt.Product)
                .FirstOrDefaultAsync();

            return new AddToCartResult
            {
                IsSuccess = true,
                CartDetail = createdCartDetailAndProductInfo
            };
        }

        private async Task<CartDetail> handleAddExistedItem(
            CartDetail cartDetail,
            ProductTier productTier)
        {
            var existingCartDetail = await _context.CartDetails
                .SingleOrDefaultAsync(c =>
                    c.ProductTierId == cartDetail.ProductTierId &&
                    c.CartId == cartDetail.CartId);

            if (existingCartDetail != null)
            {
                int newQuantity = cartDetail.Quantity + existingCartDetail.Quantity;

                if (newQuantity > productTier.Quantity)
                {
                    return null;
                }

                existingCartDetail.Quantity = newQuantity;
                var result = await UpdateAsync(existingCartDetail);
                if (result.IsSuccess)
                {
                    return existingCartDetail;
                }

                return null;
            }

            return null;
        }

        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllCartDetailsFilter filter = null)
        {
            var queryable = _context.CartDetails.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
        }

        public async Task<bool> DeleteAllAsync(int requestedUserId)
        {
            var customer = await _context.Customers
                .Where(x => x.UserId == requestedUserId)
                .Include(x => x.Cart)
                .FirstOrDefaultAsync();

            if (customer == null || customer.Cart == null)
            {
                return false;
            }

            var deletedCartDetails = await _context.CartDetails
                .Where(x => x.CartId == customer.Cart.Id)
                .ToListAsync();

            _context.CartDetails.RemoveRange(deletedCartDetails);
            var deleted = await _context.SaveChangesAsync();

            return deleted > 0;
        }

        public async Task<bool> DeleteAsync(int cartDetailId)
        {
            var cartDetail = await _context.CartDetails
                .SingleOrDefaultAsync(c => c.Id == cartDetailId);

            if (cartDetail == null)
            {
                return false;
            }

            _context.CartDetails.Remove(cartDetail);
            var deleted = await _context.SaveChangesAsync();

            return deleted > 0;
        }

        public async Task<IEnumerable<CartDetail>> GetAllAsync(
            PaginationFilter pagination,
            GetAllCartDetailsFilter filter = null)
        {
            var queryable = _context.CartDetails.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Include(cDetail => cDetail.ProductTier)
                    .ThenInclude(productTier => productTier.Product)
                        .ThenInclude(product => product.ProductImages)
                .Skip(skip)
                .Take(pagination.PageSize)
                .ToListAsync();
        }

        public async Task<CartDetail> GetByIdAsync(int cartDetailId)
        {
            return await _context.CartDetails
                .Where(cDetail => cDetail.Id == cartDetailId)
                .Include(cDetail => cDetail.ProductTier)
                    .ThenInclude(productTier => productTier.Product)
                        .ThenInclude(product => product.ProductImages)
                .FirstOrDefaultAsync();
        }

        public async Task<UpdateCartDetailResult> UpdateAsync(CartDetail cartDetail)
        {
            /** handle quantity of product */
            var productTier = await _context.ProductTiers
                .SingleOrDefaultAsync(p => p.Id == cartDetail.ProductTierId);
            if (cartDetail.Quantity > productTier.Quantity)
            {
                return new UpdateCartDetailResult
                {
                    IsSuccess = false,
                    Errors = new[] { "The quantity of product is not enough" }
                };
            }

            _context.CartDetails.Update(cartDetail);
            var updated = await _context.SaveChangesAsync();

            return new UpdateCartDetailResult
            {
                IsSuccess = true
            };
        }

        private IQueryable<CartDetail> AddFilterOnQuery(
            GetAllCartDetailsFilter filter,
            IQueryable<CartDetail> queryable
        )
        {
            return queryable;
        }
    }
}
