using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Product;
using Banana_E_Commerce_API.Enums;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Product
{
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            // Name
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(255);

            // Price Currency
            List<PriceCurrency> validPriceCurrencyValues = new List<PriceCurrency>()
                { PriceCurrency.Dollar, PriceCurrency.VND };
            RuleFor(x => x.PriceCurrency)
                .NotEmpty()
                .Must(x => validPriceCurrencyValues.Contains(x))
                    .WithMessage("Price currency value is not valid");

        }
    }
}