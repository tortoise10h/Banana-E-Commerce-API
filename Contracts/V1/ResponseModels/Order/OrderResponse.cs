using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Address;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.OrderItem;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.PaymentMethod;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Order
{
    public class OrderResponse
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
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentMethodId { get; set; }
        public string StripeClientSecret { get; set; }
        public string PaymentIntentId { get; set; }
        public bool IsPayed { get; set; }

        public CustomerResponse Customer { get; set; }
        public AddressResponse Address { get; set; }
        public PaymentMethodResponse PaymentMethod { get; set; }
        public IEnumerable<OrderItemResponse> OrderItems { get; set; }
    }
}