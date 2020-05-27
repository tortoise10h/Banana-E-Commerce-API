using Banana_E_Commerce_API.Contracts.V1.RequestModels.CartDetail;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.CartDetail
{
    public class AddProductToCartRequestValidator : AbstractValidator<AddProductToCartRequest>
    {
        public AddProductToCartRequestValidator()
        {
            // CartId
            RuleFor(x => x.CartId)
                .NotNull()
                .GreaterThan(0);

            // ProductId
            RuleFor(x => x.ProductTierId)
              .NotEmpty();

            // Quantity
            RuleFor(x => x.Quantity)
              .NotNull()
              .GreaterThan(0);
        }
    }
}