using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportDetail;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportProduct
{
    public class CreateRequestImportProductRequest
    {
        public IEnumerable<CreateRequestImportDetailRequest> RequestImportDetails { get; set; }
    }
}