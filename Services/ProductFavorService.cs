using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductFavor;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductFavorService
    {
        Task<CreateProductFavorResult> CreateAsync(ProductFavorite productFavor, int userId);
        Task<bool> DeleteAsync(int productFavorId);
        Task<IEnumerable<ProductFavorite>> GetAllAsync(
            int userId,
            PaginationFilter pagination,
            GetAllProductFavoritesFilter filter = null);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductFavoritesFilter filter = null
        );
        Task<ProductFavorite> GetByIdAsync(int productFavorId);
        Task<bool> IsCustomerOwnInfo(int userId, int customerId);
        Task<bool> DeleteAllAsync(int requestedUserId);
    }

    public class ProductFavorService : IProductFavorService
    {
        private readonly DataContext _context;

        public ProductFavorService(DataContext context)
        {
            _context = context;
        }

        public async Task<CreateProductFavorResult> CreateAsync(ProductFavorite productFavor, int userId)
        {
            var createdByCustomer = await _context.Customers.SingleOrDefaultAsync(c => c.UserId == userId);
            var newProduct = await _context.ProductTiers.SingleOrDefaultAsync(p => p.Id == productFavor.ProductTierId);
            var currentProduct = await _context.ProductFavorites
                .SingleOrDefaultAsync(p => p.ProductTierId == productFavor.ProductTierId && p.CustomerId == createdByCustomer.Id);

            if (currentProduct != null)
            {
                return new CreateProductFavorResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Sản phẩm đã tồn tại trong danh sách yêu thích của bạn" }
                };
            }

            if (newProduct == null)
            {
                return new CreateProductFavorResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Sản phẩm này không tồn tại" }
                };
            }

            productFavor.CustomerId = createdByCustomer.Id;

            await _context.ProductFavorites.AddAsync(productFavor);
            var created = await _context.SaveChangesAsync();

            var createdProductFavor = await GetByIdAsync(productFavor.Id);

            return new CreateProductFavorResult
                {
                    IsSuccess = true,
                    ProductFavorite = createdProductFavor
                };
        }

        public async Task<ProductFavorite> GetByIdAsync(int id)
        {
            return await _context.ProductFavorites
                .Where(a => a.Id == id)
                .Include(pdf => pdf.ProductTier)
                    .ThenInclude(pt => pt.Product)
                        .ThenInclude(p => p.ProductImages)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ProductFavorite>> GetAllAsync(
            int userId,
            PaginationFilter pagination,
            GetAllProductFavoritesFilter filter = null
        )
        {
            var customer = await _context.Customers.SingleOrDefaultAsync(c => c.UserId == userId);
            var queryable = _context.ProductFavorites.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Where(c => c.CustomerId == customer.Id)
                .Skip(skip)
                .Take(pagination.PageSize)
                .Include(pdf => pdf.ProductTier)
                    .ThenInclude(pt => pt.Product)
                        .ThenInclude(p => p.ProductImages)
                .ToListAsync();
        }

        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductFavoritesFilter filter = null
        )
        {
            var queryable = _context.ProductFavorites.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
        }

        public async Task<bool> DeleteAsync(int productFavorId)
        {
            var productFavor = await _context.ProductFavorites
                .SingleOrDefaultAsync(c => c.Id == productFavorId);

            if (productFavor == null)
            {
                return false;
            }

            _context.ProductFavorites.Remove(productFavor);
            var deleted = await _context.SaveChangesAsync();

            return deleted > 0;
        }

        public async Task<bool> DeleteAllAsync(int requestedUserId)
        {
            var customer = await _context.Customers
                .Where(c => c.UserId == requestedUserId)
                .Include(c => c.ProductFavorites)
                .FirstOrDefaultAsync();
            
            if (customer == null || customer.ProductFavorites == null)
            {
                return false;
            }

            _context.ProductFavorites.RemoveRange(customer.ProductFavorites);
            var deleted = await _context.SaveChangesAsync();

            return deleted > 0;
        }

        public async Task<bool> IsCustomerOwnInfo(int userId, int customerId)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == userId);
            var customer = await _context.Customers
                .Where(u => u.Id == customerId && 
                        u.UserId == user.Id)
                    .FirstOrDefaultAsync();

            if (customer == null)
            {
                return false;
            }
            
            return true;
        }

        private IQueryable<ProductFavorite> AddFilterOnQuery(
            GetAllProductFavoritesFilter filter,
            IQueryable<ProductFavorite> queryable
        )
        {
            return queryable;
        }
    }
}