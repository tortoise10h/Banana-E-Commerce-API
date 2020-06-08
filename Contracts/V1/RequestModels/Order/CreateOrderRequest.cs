using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.OrderItem;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Order
{
    public class CreateOrderRequest
    {
        public string IdealShipTime { get; set; }
        public bool IsGift { get; set; }
        public string Notes { get; set; }
        public int AddressId { get; set; }
        public int PaymentMethodId { get; set; }
        // public IEnumerable<CreateOrderItemRequest> OrderItems { get; set; }
    }
}