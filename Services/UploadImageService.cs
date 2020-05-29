using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.UploadImage;
using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Services
{
    public interface IUploadImageService
    {
        Task<UploadSingleImageResult> UploadSingleImage(
            string appRootDir,
            string categoryDir,
            IFormFile image
        );
    }

    public class UploadImageService : IUploadImageService
    {
        public async Task<UploadSingleImageResult> UploadSingleImage(
            string appRootDir,
            string categoryDir,
            IFormFile image)
        {
            bool isUploadSuccess = true;
            List<string> errors = new List<string>();

            /** Check available category dir */
            if (!Directory.Exists(categoryDir))
            {
                Directory.CreateDirectory(categoryDir);
            }

            /** Create custom file name and file path */
            string fileExtension = Path.GetExtension(image.FileName);
            string customFileName = Guid.NewGuid().ToString();
            string customFileNameWithExtension = $"{customFileName}{fileExtension}";
            string path = Path.Combine(categoryDir, customFileNameWithExtension);
            string fullPath = appRootDir + path;

            /** Put handle file into using to handle the unexpected error */
            try
            {
                using (FileStream fileStream = new FileStream(
                fullPath,
                FileMode.Create,
                FileAccess.Write))
                {
                    /** Save file to directory */
                    await image.CopyToAsync(fileStream);
                }
            }
            catch (Exception e)
            {
                isUploadSuccess = false;
                errors.Add(e.Message.ToString());
            }

            if (!isUploadSuccess)
            {
                return new UploadSingleImageResult
                {
                    IsSuccess = isUploadSuccess,
                    Errors = errors
                };
            }

            return new UploadSingleImageResult
            {
                IsSuccess = isUploadSuccess,
                ImageLocation = path
            };
        }
    }
}