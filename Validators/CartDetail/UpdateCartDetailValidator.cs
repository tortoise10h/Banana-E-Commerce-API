using Banana_E_Commerce_API.Contracts.V1.RequestModels.CartDetail;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.CartDetail
{
    public class UpdateCartDetailValidator : AbstractValidator<UpdateCartDetailRequest>
    {
        public UpdateCartDetailValidator()
        {
            // Quantity
            RuleFor(x => x.Quantity)
              .GreaterThan(0);
        }
    }
}