using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportDetail;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportProduct
{
    public class RequestImportProductResponse
    {
        public int Id { get; set; }
        public RequestImportProductStatus Status { get; set; }

        public int CreatedBy { get; set; }
        public IEnumerable<RequestImportDetailResponse> RequestImportDetails { get; set; }
    }
}