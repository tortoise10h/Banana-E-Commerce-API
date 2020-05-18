using System;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Shipper
{
    public class ShipperResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public int CreatedBy { get; set; }
    }
}