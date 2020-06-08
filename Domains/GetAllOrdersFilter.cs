using System;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Domains
{
    public class GetAllOrdersFilter
    {
        public OrderStatus OrderStatus { get; set; }
        public double FromAmount { get; set; }
        public double ToAmount { get; set; }
        public string Code { get; set; }
        public DateTime IdealShipTime { get; set; }
        public BooleanSearch IsGift { get; set; }
        public string Notes { get; set; }
        public BooleanSearch IsCustomerReceive { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CustomerId { get; set; }
        public MethodOfPayment MethodOfPayment { get; set; }
    }
}