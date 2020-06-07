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
            RuleFor(x => x.EntryPrice)
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

            // StorageId
            RuleFor(x => x.StorageId)
                .NotNull()
                .GreaterThan(0); ;

            // CategoryId
            RuleFor(x => x.CategoryId)
                .NotNull()
                .GreaterThan(0);

            // Origin
            RuleFor(x => x.Origin)
                .NotEmpty()
                .MaximumLength(255);

            // Images
            RuleForEach(x => x.Images)
                .SetValidator(new ImageUploadValidator());

            // PricePerKg
            RuleFor(x => x.PricePerKg)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            // KgSale
            RuleFor(x => x.KgSale)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            // DiscountPercentage
            RuleFor(x => x.DiscountPercentage)
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
    }
}