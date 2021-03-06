using FluentValidation;
using FluentValidation.Validators;
using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Validators.ProductImage
{
    public class ImageUploadValidator : AbstractValidator<IFormFile>
    {
        public ImageUploadValidator()
        {
            // Length
            RuleFor(x => x.Length)
                .NotNull()
                .LessThanOrEqualTo(10 * 1024 * 1024)
                .WithMessage("Kích thước hình ảnh lớn hơn mức cho phép");

            // Content Type
            RuleFor(x => x.ContentType)
                .NotNull()
                .Must(x => x.Equals("image/jpeg") ||
                    x.Equals("image/jpg") ||
                    x.Equals("image/png") ||
                    x.Equals("image/gif"))
                .WithMessage("Định dạng file không hợp lệ, vui lòng thử lại");
        }
    }
}