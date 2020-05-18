using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductService
    {
        Task<CreateProductResult> CreateAsync(Product product, int createdProductUserId);
        Task<bool> UpdateAsync(Product product);
        Task<Product> GetByIdAsync(int productId);
        Task<IEnumerable<Product>> GetAllAsync(
            PaginationFilter pagination,
            GetAllProductsFilter filter = null);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductsFilter filter = null
        );
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

        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductsFilter filter = null
        )
        {
            var queryable = _context.Products.AsQueryable();

            queryable = queryable.Where(x => x.IsDeleted == false);
            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
        }

        public async Task<CreateProductResult> CreateAsync(Product product, int createdProductUserId)
        {
            var createdAdmin = await _context.Admins.SingleOrDefaultAsync(x => x.UserId == createdProductUserId);

            product.CreatedBy = createdAdmin.Id;
            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;
            product.IsDeleted = false;

            /** Check exist storage */
            var existedStorage = await _context.Storages.SingleOrDefaultAsync(s => s.Id == product.StorageId);
            if (existedStorage == null)
            {
                return new CreateProductResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Storage is not existed" }
                };
            }

            /** Check exist category */
            var existedCategory = await _context.Categories.SingleOrDefaultAsync(c => c.Id == product.CategoryId);
            if (existedCategory == null)
            {
                return new CreateProductResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Category of product is not existed" }
                };
            }

            await _context.Products.AddAsync(product);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new CreateProductResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Created product error" }
                };
            }

            return new CreateProductResult
            {
                IsSuccess = true
            };
        }

        public async Task<IEnumerable<Product>> GetAllAsync(
            PaginationFilter pagination,
            GetAllProductsFilter filter = null)
        {
            var queryable = _context.Products.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Skip(skip)
                .Take(pagination.PageSize)
                .ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            return await _context.Products.SingleOrDefaultAsync(x => x.Id == productId);
        }

        public async Task<bool> UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }

        private IQueryable<Product> AddFilterOnQuery(
            GetAllProductsFilter filter,
            IQueryable<Product> queryable
        )
        {
            if (!string.IsNullOrEmpty(filter?.Name))
            {
                queryable = queryable.Where(x => x.Name.Contains(filter.Name));
            }

            if (filter?.CategoryIds.Count() > 0)
            {
                queryable = queryable.Where(x => filter.CategoryIds.Contains(x.CategoryId));
            }

            if (filter?.StorageId > 0)
            {
                queryable = queryable.Where(x => x.StorageId == filter.StorageId);
            }

            if (filter?.FromPrice != null)
            {
                queryable = queryable.Where(x => x.SalePrice >= filter.FromPrice);
            }

            if (filter?.ToPrice != null && filter.ToPrice > 0)
            {
                queryable = queryable.Where(x => x.SalePrice <= filter.ToPrice);
            }
            return queryable;
        }
    }
}