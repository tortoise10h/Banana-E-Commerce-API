using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using System.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Banana_E_Commerce_API.Domains;

namespace Banana_E_Commerce_API.Services
{
    public interface ICategoryService
    {
        Task<bool> CreateAsync(Category category, int createdCategoryUserId);
        Task<Category> GetByIdAsync(int id);
        Task<bool> UpdateAsync(Category category);
        Task<IEnumerable<Category>> GetAllAsync(PaginationFilter paginationFilter
        , GetAllCategoriesFilter filter = null);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAllAsync();
    }

    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(Category category, int createdCategoryUserId)
        {
            var createdCategoryAdmin = _context.Admins.SingleOrDefault(a => a.UserId == createdCategoryUserId);

            category.UpdatedAt = DateTime.UtcNow;
            category.CreatedAt = DateTime.UtcNow;
            category.IsDeleted = false;
            category.CreatedBy = createdCategoryAdmin.Id;

            await _context.Categories.AddAsync(category);
            var created = await _context.SaveChangesAsync();

            return created > 0;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllAsync(
            PaginationFilter pagination,
            GetAllCategoriesFilter filter = null)
        {
            var queryable = _context.Categories.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Skip(skip)
                .Take(pagination.PageSize)
                .ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Category category)
        {
            _context.Categories.Update(category);
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }

        public async Task<int> CountAllAsync()
        {
            return await _context.Categories.CountAsync();
        }

        private IQueryable<Category> AddFilterOnQuery(
            GetAllCategoriesFilter filter,
            IQueryable<Category> queryable
        )
        {
            if (!string.IsNullOrEmpty(filter?.Name))
            {
                queryable = queryable.Where(x => x.Name.Contains(filter.Name));
            }

            if (filter?.CreatedBy > 0)
            {
                queryable = queryable.Where(x => x.CreatedBy == filter.CreatedBy);
            }

            return queryable;
        }
    }
}