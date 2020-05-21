using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductImage;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.ProductImage
{
    public class CreateProductImageRequestValidator : AbstractValidator<CreateProductImageRequest>
    {
        public CreateProductImageRequestValidator()
        {
            RuleFor(x => x.ProductId)
                .NotNull();
        }
    }
}