using System;
using System.Collections.Generic;
using System.Linq;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Services
{
    public interface IEmailTemplateService
    {
        string CreateOrderHtmlTempalteToSendMailToCustomer(
            string orderCode,
            double orderTotalAmount,
            DateTime orderDate,
            IEnumerable<OrderItem> orderItems,
            IEnumerable<ProductTier> productTiers,
            string customerName,
            string customerEmail
        );

        string CancelOrderTemplate(
            string customerName,
            string orderCode,
            string cancelReason
        );
    }

    public class EmailTemplateService : IEmailTemplateService
    {
        public string CancelOrderTemplate(
            string customerName,
            string orderCode,
            string cancelReason
        )
        {
            string template = "";
            template += $"<p>Kính gửi khách hàng '{customerName}', ";
            // template += $"Banana Boys Fruits xin rất tiếc thông báo vì lý do số lượng hàng hoá trong kho hiện nay không đáp ứng được yêu cầu trong đơn hàng {orderCode} của bạn";
            // template += $"nên chúng tôi sẽ huỷ đơn hàng này của bạn</p>";
            template += $"<p>{cancelReason}</p>";
            template += $"<p>Kính mong bạn thông cảm cho sự bất tiện này của cửa hàng và mong bạn sẽ quay lại mua những mặt hàng khác của cửa hàng</p>";
            template += "<p>Xin trân trọng cảm ơn</p>";

            return template;
        }

        public string CreateOrderHtmlTempalteToSendMailToCustomer(
            string orderCode,
            double orderTotalAmount,
            DateTime orderDate,
            IEnumerable<OrderItem> orderItems,
            IEnumerable<ProductTier> productTiers,
            string customerName,
            string customerEmail
        )
        {
            string template = "";

            template += $"<h3>Đơn hàng của khách hàng '{customerName}' ";
            template += $"vào {orderDate.ToString("dd/MM/y yyy HH:mm:ss")} </h3>";
            template += $"<p>Mã đơn hàng: <strong>{orderCode}</strong></p><br/>";
            template += "<p>Bạn đã thanh toán thành công một đơn hàng mới tại Banana Boys Fruits, thông tin chi tiết của đơn hàng như sau:</p>";
            template += "<table>";
            template += "<tr>";
            template += "<th>Tên sản phẩm</th>";
            template += "<th>Số lượng</th>";
            template += "<th>Đơn giá</th>";
            template += "<th>Thành tiền</th>";
            template += "</tr>";

            foreach (var orderItem in orderItems)
            {
                var productTier = productTiers
                    .SingleOrDefault(pt => pt.Id == orderItem.ProductTierId);
                double orderItemTotalPrice = orderItem.SinglePrice * orderItem.Quantity;

                template += "<tr>";
                template += $"<td>{orderItem.ProductTier.Product.Name} loại {productTier.Tier.TierOption}</td>";
                template += $"<td>{orderItem.Quantity}</td>";
                template += $"<td>{orderItem.SinglePrice}đ</td>";
                template += $"<td>{orderItemTotalPrice}đ</td>";
                template += "</tr>";
            }

            template += $"<p><strong>Tổng tiền</strong>: {orderTotalAmount}đ</p>";

            return template;
        }
    }
}