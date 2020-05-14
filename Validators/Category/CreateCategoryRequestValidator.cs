using Banana_E_Commerce_API.Contracts.V1.RequestModels.Category;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Category
{
    public class CreateCategoryRequestValidator : AbstractValidator<CreateCategoryRequest>
    {
        public CreateCategoryRequestValidator()
        {
            // Name
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(255);
        }
    }
}