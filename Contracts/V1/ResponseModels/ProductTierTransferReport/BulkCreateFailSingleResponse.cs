using System.Collections.Generic;
using E = Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTierTransferReport
{
    public class BulkCreateFailSingleResponse
    {
        public List<string> Errors { get; set; }
        public ProductTierTransferReportResponse ProductTierTransferReport { get; set; }
    }
}