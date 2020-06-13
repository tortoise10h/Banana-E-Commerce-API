using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public double TotalAmount { get; set; }
        public PriceCurrency Currency { get; set; }
        public string Code { get; set; }
        public DateTime IdealShipTime { get; set; }
        public bool IsGift { get; set; }
        public string Notes { get; set; }
        public bool IsCustomerReceive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentIntentId { get; set; }
        public string StripeClientSecret { get; set; }
        public bool IsPayed { get; set; }


        public Customer Customer { get; set; }
        public CancelOrderReport CancelOrderReport { get; set; }
        public Address Address { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductExportBill> ProductExportBills { get; set; }
    }


}