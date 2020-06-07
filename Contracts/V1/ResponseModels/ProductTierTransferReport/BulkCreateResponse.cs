using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTierTransferReport
{
    public class BulkCreateResponse
    {
        public IEnumerable<ProductTierTransferReportResponse> SuccessList { get; set; }
        public IEnumerable<BulkCreateFailSingleResponse> FailList { get; set; }
    }
}