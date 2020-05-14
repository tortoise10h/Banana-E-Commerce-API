using Banana_E_Commerce_API.Contracts.V1.RequestModels.Category;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Category
{
    public class UpdateCategoryRequestValidator : AbstractValidator<UpdateCategoryRequest>
    {
        public UpdateCategoryRequestValidator()
        {
            // Name
            RuleFor(x => x.Name)
                .MaximumLength(255);
        }
    }
}