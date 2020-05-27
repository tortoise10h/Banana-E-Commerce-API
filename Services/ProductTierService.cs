using System;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductTierService
    {
        Task<CreateProductTierResult> CreateAsync(
            ProductTier productTier
        );
    }

    public class ProductTierService : IProductTierService
    {
        private readonly DataContext _context;

        public ProductTierService(
            DataContext context
        )
        {
            _context = context;
        }

        public async Task<CreateProductTierResult> CreateAsync(ProductTier productTier)
        {
            productTier.IsDeleted = false;
            productTier.CreatedAt = DateTime.UtcNow;
            productTier.UpdatedAt = DateTime.UtcNow;

            await _context.ProductTiers.AddAsync(productTier);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new CreateProductTierResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Create product tier error" }
                };
            }

            return new CreateProductTierResult
            {
                IsSuccess = true
            };
        }
    }
}