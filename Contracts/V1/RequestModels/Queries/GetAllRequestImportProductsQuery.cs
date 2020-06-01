using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries
{
    public class GetAllRequestImportProductsQuery
    {
        public RequestImportProductStatus Status { get; set; }
    }
}