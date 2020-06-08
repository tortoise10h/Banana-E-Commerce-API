using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public MethodOfPayment Method { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Admin Admin { get; set; }
        public int CreatedBy { get; set; }

        public ICollection<Order> Orders { get; set; }
    }


}