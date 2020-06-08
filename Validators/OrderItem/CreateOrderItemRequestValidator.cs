using Banana_E_Commerce_API.Contracts.V1.RequestModels.OrderItem;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.OrderItem
{
    public class CreateOrderItemRequestValidator : AbstractValidator<CreateOrderItemRequest>
    {
        public CreateOrderItemRequestValidator()
        {
            // ProductTierId
            RuleFor(x => x.ProductTierId)
                .NotEmpty();

            // Quantity
            RuleFor(x => x.Quantity)
                .NotEmpty();
        }
    }
}