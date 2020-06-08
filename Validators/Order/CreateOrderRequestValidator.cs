using Banana_E_Commerce_API.Contracts.V1.RequestModels.Order;
using Banana_E_Commerce_API.Validators.OrderItem;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Order
{
    public class CreateOrderRequestValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderRequestValidator()
        {
            // AddressId
            RuleFor(x => x.AddressId)
                .NotEmpty();

            // PaymentMethodId
            RuleFor(x => x.PaymentMethodId)
                .NotEmpty();
        }
    }
}