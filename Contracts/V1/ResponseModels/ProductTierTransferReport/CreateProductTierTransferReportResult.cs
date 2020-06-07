using System.Collections.Generic;
using E = Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTierTransferReport
{
    public class CreateProductTierTransferReportResult
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
        public E.ProductTierTransferReport ProductTierTransferReport { get; set; }
    }
}