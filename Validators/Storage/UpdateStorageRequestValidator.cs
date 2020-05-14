using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Storage;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Storage
{
    public class UpdateStorageRequestValidator : AbstractValidator<UpdateStorageRequest>
    {
        public UpdateStorageRequestValidator()
        {
            // Location
            RuleFor(x => x.Location)
                .MaximumLength(255);

            // Size
            RuleFor(x => x.Size)
                .GreaterThan(0);

            // Size Unit
            List<string> validSizeUnitValues = new List<string>() { "m2" };
            RuleFor(x => x.SizeUnit)
                .Must(x => validSizeUnitValues.Contains(x))
                    .WithMessage("Size Unit value is invalid");
        }
    }
}