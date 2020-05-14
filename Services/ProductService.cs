using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductService
    {
        Task<CreateProductResult> CreateAsync(Product product, int createdProductUserId);
    }

    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProductService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CreateProductResult> CreateAsync(Product product, int createdProductUserId)
        {
            product.CreatedBy = createdProductUserId;
            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;
            product.IsDeleted = false;

            /** Check exist storage */
            var existedStorage = _context.Storages.SingleOrDefault(s => s.Id == product.StorageId);
            if (existedStorage == null)
            {
                return new CreateProductResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Storage is not existed" }
                };
            }

            /** Check exist category */
            var existedCategory = _context.Categories.SingleOrDefault(c => c.Id == product.CategoryId);
            if (existedStorage == null)
            {
                return new CreateProductResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Category of product is not existed" }
                };
            }

            await _context.Products.AddAsync(product);
            var created = await _context.SaveChangesAsync();

            return new CreateProductResult
            {
                IsSuccess = true
            };
        }
    }
}