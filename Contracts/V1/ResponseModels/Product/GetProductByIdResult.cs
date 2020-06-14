using E = Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product
{
    public class GetProductByIdResult
    {
        public E.Product Product { get; set; }
        public double ProductTier1AverageRate { get; set; }
        public double ProductTier2AverageRate { get; set; }
    }
}