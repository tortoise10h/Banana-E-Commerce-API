using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RatingImage;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IRatingImageService
    {
        Task<UploadMultipleRatingImagesResult> UploadMultipleRatingImages(
            string appRootDir,
            string productImageDir,
            int ratingId,
            int productTierId,
            IEnumerable<IFormFile> files);
    }
    public class RatingImageService :IRatingImageService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

         public RatingImageService(
            DataContext context,
            IMapper mapper
        )
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UploadMultipleRatingImagesResult> UploadMultipleRatingImages(
            string appRootDir,
            string ratingImageDir,
            int ratingId,
            int productTierId,
            IEnumerable<IFormFile> files)
        {
            List<RatingImage> ratingImages = new List<RatingImage>();

            /** Check available product image dir */
            if (!Directory.Exists(ratingImageDir))
            {
                Directory.CreateDirectory(ratingImageDir);
            }

            foreach (var file in files)
            {
                /** Create custom file name and file path */
                string fileExtension = Path.GetExtension(file.FileName);
                string customFileName = Guid.NewGuid().ToString();
                string customFileNameWithExtension = $"{customFileName}{fileExtension}";
                string path = Path.Combine(ratingImageDir, customFileNameWithExtension);
                string fullPath = appRootDir + path;

                ratingImages.Add(new RatingImage
                {
                    ImgLocation = path,
                    ImgName = customFileName,
                    RatingId = ratingId,
                    ProductTierId = productTierId
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

            _context.RatingImages.AddRange(ratingImages);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new UploadMultipleRatingImagesResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Có lỗi khi tải hình ảnh lên, vui lòng thử lại" }
                };
            }

            var ratingImageResponses = _mapper.Map<List<RatingImage>, List<RatingImageResponse>>(ratingImages);
            return new UploadMultipleRatingImagesResult
            {
                IsSuccess = true,
                RatingImages = ratingImageResponses
            };
        }
    }
}