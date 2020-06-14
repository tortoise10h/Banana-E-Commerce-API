using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductImage;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductImageService
    {
        Task<UploadMultipleProductImagesResult> UploadMultipleProductImages(
            string appRootDir,
            string productImageDir,
            int productId,
            IEnumerable<IFormFile> files);
        Task<ProductImage> GetByIdAsync(int productImageId);
        Task<bool> DeleteAsync(ProductImage productImage);
    }

    public class ProductImageService : IProductImageService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProductImageService(
            DataContext context,
            IMapper mapper
        )
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync(ProductImage productImage)
        {
            _context.ProductImages.Remove(productImage);
            var deleted = await _context.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<ProductImage> GetByIdAsync(int productImageId)
        {
            return await _context.ProductImages
                .SingleOrDefaultAsync(x => x.Id == productImageId &&
                    x.IsDeleted == false);
        }

        public async Task<UploadMultipleProductImagesResult> UploadMultipleProductImages(
            string appRootDir,
            string productImageDir,
            int productId,
            IEnumerable<IFormFile> files)
        {
            List<ProductImage> productImages = new List<ProductImage>();

            /** Check available product image dir */
            if (!Directory.Exists(productImageDir))
            {
                Directory.CreateDirectory(productImageDir);
            }

            foreach (var file in files)
            {
                /** Create custom file name and file path */
                string fileExtension = Path.GetExtension(file.FileName);
                string customFileName = Guid.NewGuid().ToString();
                string customFileNameWithExtension = $"{customFileName}{fileExtension}";
                string path = Path.Combine(productImageDir, customFileNameWithExtension);
                string fullPath = appRootDir + path;

                productImages.Add(new ProductImage
                {
                    ImgLocation = path,
                    ImgName = customFileName,
                    ProductId = productId
                });

                /** Put handle file into using to handle the unexpected error */
                using (FileStream fileStream = new FileStream(
                    fullPath,
                    FileMode.Create,
                    FileAccess.Write))
                {
                    /** Save file to directory */
                    await file.CopyToAsync(fileStream);
                }
            }

            _context.ProductImages.AddRange(productImages);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new UploadMultipleProductImagesResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Có lỗi khi tải hình ảnh lên, vui lòng thử lại" }
                };
            }

            var productImageResponses = _mapper.Map<List<ProductImage>, List<ProductImageResponse>>(productImages);
            return new UploadMultipleProductImagesResult
            {
                IsSuccess = true,
                ProductImages = productImageResponses
            };
        }
    }
}