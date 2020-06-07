using System;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.StorageManager;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTierTransferReport
{
    public class ProductTierTransferReportResponse
    {
        public int Id { get; set; }
        public int FromTierId { get; set; }
        public int ToTierId { get; set; }
        public double Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }

        public StorageManagerResponse StorageManager { get; set; }
        public ProductTierResponse ProductTier { get; set; }
    }
}