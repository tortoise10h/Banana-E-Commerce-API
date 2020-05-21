using System.Collections.Generic;
using System.Linq;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Product;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Validators.ProductImage;
using FluentValidation;
using Microsoft.AspNetCore.Http;

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

            // Quantity
            RuleFor(x => x.Quantity)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            // Price
            RuleFor(x => x.Price)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            // Sale Price
            RuleFor(x => x.SalePrice)
                .NotNull()
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

            // Images
            RuleForEach(x => x.Images)
                .SetValidator(new ImageUploadValidator());

        }
    }
}