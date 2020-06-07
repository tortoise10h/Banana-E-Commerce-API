using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTierTransferReport
{
    public class BulkCreateProductTierTransferReportRequest
    {
        public IEnumerable<CreateProductTierTransferReportRequest> productTierTransferReports { get; set; }
    }
}