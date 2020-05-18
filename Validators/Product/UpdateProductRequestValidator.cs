using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Product;
using Banana_E_Commerce_API.Enums;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Product
{
    public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
    {
        public UpdateProductRequestValidator()
        {
            // Name
            RuleFor(x => x.Name)
                .MaximumLength(255);

            // Price
            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(0);

            // Sale Price
            RuleFor(x => x.SalePrice)
                .GreaterThanOrEqualTo(0);

            // Quantity
            RuleFor(x => x.Quantity)
                .GreaterThanOrEqualTo(0);

            // Price Currency
            RuleFor(x => x.PriceCurrency)
                .IsInEnum()
                .WithMessage("Price currency value is not valid");

            // Product Unit
            RuleFor(x => x.ProductUnit)
                .IsInEnum()
                .WithMessage("Product Unit value is not valid");

            // Origin
            RuleFor(x => x.Origin)
                .NotEmpty()
                .MaximumLength(255);
        }
    }
}