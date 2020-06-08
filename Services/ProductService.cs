using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductService
    {
        Task<CreateProductResult> CreateAsync(
            Product product,
            ProductTier productTier,
            int createdProductUserId,
            IEnumerable<IFormFile> images,
            string productImageDir,
            string appRootDir);
        Task<bool> UpdateAsync(Product product);
        Task<Product> GetByIdAsync(int productId);
        Task<IEnumerable<Product>> GetAllAsync(
            PaginationFilter pagination,
            GetAllProductsFilter filter = null);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductsFilter filter = null
        );

        double CalculateAfterDiscountPrice(
            double originalPrice,
            int discountPercentage
        );
    }

    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IProductImageService _productImageService;
        private readonly IProductTierService _productTierService;
        private readonly ITierService _tierService;

        public ProductService(
            DataContext context,
            IMapper mapper,
            IProductImageService productImageService,
            IProductTierService productTierService,
            ITierService tierService)
        {
            _context = context;
            _mapper = mapper;
            _productImageService = productImageService;
            _productTierService = productTierService;
            _tierService = tierService;
        }

        public double CalculateAfterDiscountPrice(double originalPrice, int discountPercentage)
        {
            double discountPrice = (originalPrice * discountPercentage) / 100;
            double afterDiscountPrice = Math.Floor(originalPrice - discountPrice);

            return afterDiscountPrice;
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

        public async Task<CreateProductResult> CreateAsync(
            Product product,
            ProductTier productTier,
            int createdProductUserId,
            IEnumerable<IFormFile> images,
            string productImageDir,
            string appRootDir)
        {
            var prepareProductInfoResult = await PrepareNewProductInfo(
                product,
                createdProductUserId
            );
            if (prepareProductInfoResult.IsSuccess == false)
            {
                return new CreateProductResult
                {
                    IsSuccess = false,
                    Errors = prepareProductInfoResult.Errors
                };
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    /** Create product */
                    await _context.Products.AddAsync(product);
                    var created = await _context.SaveChangesAsync();
                    if (!(created > 0))
                    {
                        transaction.Dispose();
                        throw new Exception("Có lỗi khi tạo sản phẩm mới, vui lòng thử lại");
                    }

                    /** Create Images of product */
                    // only work if images are existed
                    bool isUploadImageSuccess = await UploadImagesWhenCreateProduct(
                        images,
                        appRootDir,
                        productImageDir,
                        product.Id
                    );
                    if (isUploadImageSuccess == false)
                    {
                        transaction.Dispose();
                        throw new Exception("Có lỗi khi tạo sản phẩm mới, vui lòng thử lại");
                    }

                    /** Create product tiers */
                    bool isCreatedProductTiersSuccess = await CreateProductTiersWhenCreateNewProduct(
                        productTier,
                        product.Id
                    );

                    if (!isCreatedProductTiersSuccess)
                    {
                        transaction.Dispose();
                        throw new Exception("Có lỗi khi tạo sản phẩm mới, vui lòng thử lại");
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    return new CreateProductResult
                    {
                        IsSuccess = false,
                        Errors = new[] { e.Message.ToString() }
                    };
                }
            }

            return new CreateProductResult
            {
                IsSuccess = true
            };
        }

        private async Task<PrepareProductInfoResult> PrepareNewProductInfo(
            Product product,
            int createdProductUserId
        )
        {
            var createdAdmin = await _context.Admins
                .SingleOrDefaultAsync(x => x.UserId == createdProductUserId);

            product.CreatedBy = createdAdmin.Id;
            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;
            product.Status = ProductStatus.NewGoodsImported;
            product.IsDeleted = false;

            /** Check exist storage */
            var existedStorage = await _context.Storages
                .SingleOrDefaultAsync(s => s.Id == product.StorageId);
            if (existedStorage == null)
            {
                return new PrepareProductInfoResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    { "Kho nhập hàng không tồn tại" }
                };
            }

            /** Check exist category */
            var existedCategory = await _context.Categories
                .SingleOrDefaultAsync(c => c.Id == product.CategoryId);
            if (existedCategory == null)
            {
                return new PrepareProductInfoResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    { "Danh mục sản phẩm không tồn tại" }
                };
            }

            return new PrepareProductInfoResult
            {
                IsSuccess = true,
                Product = product
            };
        }

        private async Task<bool> UploadImagesWhenCreateProduct(
            IEnumerable<IFormFile> images,
            string appRootDir,
            string productImageDir,
            int productId
        )
        {
            if (images != null && images.Count() > 0)
            {
                var createProductImageResult = await _productImageService
                    .UploadMultipleProductImages(
                        appRootDir,
                        productImageDir,
                        productId,
                        images
                    );

                return createProductImageResult.IsSuccess;
            }

            return true;
        }

        private async Task<bool> CreateProductTiersWhenCreateNewProduct(
            ProductTier productTier1,
            int productId
        )
        {
            /** Get tiers */
            var tier1AndTier2 = await _context.Tiers
                .Where(t => t.TierOption == TierEnum.tier1 ||
                    t.TierOption == TierEnum.tier2)
                .ToListAsync();
            var tier1 = tier1AndTier2.SingleOrDefault(t => t.TierOption == TierEnum.tier1);
            var tier2 = tier1AndTier2.SingleOrDefault(t => t.TierOption == TierEnum.tier2);

            /** Prepare product tier info */
            // prepare tier 1 info
            productTier1.IsDeleted = false;
            productTier1.CreatedAt = DateTime.UtcNow;
            productTier1.UpdatedAt = DateTime.UtcNow;
            productTier1.TierId = tier1.Id;
            productTier1.ProductId = productId;
            productTier1.SalePrice = Math.Floor(productTier1.PricePerKg * productTier1.KgSale);
            productTier1.AfterDiscountPrice = CalculateAfterDiscountPrice(
                productTier1.SalePrice,
                productTier1.DiscountPercentage
            );

            // Create product tier 2 too
            // but the new product tier 2 will has quantity 0 
            ProductTier productTier2 = new ProductTier
            {
                ProductId = productId,
                TierId = tier2.Id,
                Quantity = 0,
                PricePerKg = productTier1.PricePerKg,
                SalePrice = productTier1.SalePrice,
                KgSale = productTier1.KgSale,
                DiscountPercentage = productTier1.DiscountPercentage,
                AfterDiscountPrice = productTier1.AfterDiscountPrice,
                PriceCurrency = productTier1.PriceCurrency,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsDeleted = false
            };

            await _context.AddRangeAsync(
                new List<ProductTier>()
                {
                    productTier1,
                    productTier2
                }
            );
            var created = await _context.SaveChangesAsync();

            return created > 0;
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
                .Include(p => p.ProductImages)
                .Include(p => p.ProductTiers)
                    .ThenInclude(pt => pt.Tier)
                .ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            return await _context.Products
                .Where(x => x.Id == productId &&
                    x.IsDeleted == false)
                .Include(x => x.ProductImages)
                .Include(x => x.ProductTiers)
                .FirstOrDefaultAsync();
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
            queryable = queryable.Where(x => x.IsDeleted == false);

            if (!string.IsNullOrEmpty(filter?.Name))
            {
                queryable = queryable.Where(x => x.Name.Contains(filter.Name));
            }

            if (filter?.CategoryIds.Length > 0)
            {
                queryable = queryable.Where(x => filter.CategoryIds.Contains(x.CategoryId));
            }

            if (filter?.StorageId > 0)
            {
                queryable = queryable.Where(x => x.StorageId == filter.StorageId);
            }

            if (filter?.ProductTier1FromPrice != null)
            {
                queryable = queryable.Where(x =>
                    x.ProductTiers
                        .SingleOrDefault(
                            pt => pt.Tier.TierOption == TierEnum.tier1
                        )
                            .AfterDiscountPrice >= filter.ProductTier1FromPrice);
            }

            if (filter?.ProductTier1ToPrice != null && filter.ProductTier1ToPrice > 0)
            {
                queryable = queryable.Where(x =>
                    x.ProductTiers
                        .SingleOrDefault(
                            pt => pt.Tier.TierOption == TierEnum.tier1
                        )
                            .AfterDiscountPrice <= filter.ProductTier1ToPrice);
            }
            if (filter?.ProductTier2FromPrice != null)
            {
                queryable = queryable.Where(x =>
                    x.ProductTiers
                        .SingleOrDefault(
                            pt => pt.Tier.TierOption == TierEnum.tier2
                        )
                            .AfterDiscountPrice >= filter.ProductTier2FromPrice);
            }

            if (filter?.ProductTier2ToPrice != null && filter.ProductTier2ToPrice > 0)
            {
                queryable = queryable.Where(x =>
                    x.ProductTiers
                        .SingleOrDefault(
                            pt => pt.Tier.TierOption == TierEnum.tier2
                        )
                            .AfterDiscountPrice <= filter.ProductTier2ToPrice);
            }
            return queryable;
        }
    }
}