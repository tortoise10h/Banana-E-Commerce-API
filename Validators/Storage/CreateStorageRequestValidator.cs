using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Storage;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Storage
{
    public class CreateStorageRequestValidator : AbstractValidator<CreateStorageRequest>
    {
        public CreateStorageRequestValidator()
        {
            // Location
            RuleFor(x => x.Location)
                .NotEmpty()
                .MaximumLength(255);

            // Size
            RuleFor(x => x.Size)
                .NotNull()
                .GreaterThan(0);

            // Size Unit
            List<string> validSizeUnitValues = new List<string>() { "m2" };
            RuleFor(x => x.SizeUnit)
                .NotNull()
                .Must(x => validSizeUnitValues.Contains(x))
                    .WithMessage("Đơn vị kích cỡ không hợp lệ");
        }
    }
}