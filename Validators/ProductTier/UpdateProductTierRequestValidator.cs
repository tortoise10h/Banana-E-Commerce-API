using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTier;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.ProductTier
{
    public class UpdateProductTierRequestValidator: AbstractValidator<UpdateProductTierRequest>
    {
        public UpdateProductTierRequestValidator()
        {
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

            // Quantity
            RuleFor(x => x.Quantity)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            // Price Currency
            RuleFor(x => x.PriceCurrency)
                .IsInEnum()
                .WithMessage("Đơn vị tiền tệ không hợp lệ");

        }
    }
}