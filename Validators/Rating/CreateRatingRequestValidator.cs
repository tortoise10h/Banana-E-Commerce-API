using Banana_E_Commerce_API.Contracts.V1.RequestModels.Rating;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Rating
{
    public class CreateRatingRequestValidator : AbstractValidator<CreateRatingRequest>
    {
        public CreateRatingRequestValidator()
        {
            // Comment
            RuleFor(x => x.Comment)
                .MaximumLength(5000);

            // StarNum
            RuleFor(x => x.StarNum)
                .NotNull()
                .InclusiveBetween(1, 5)
                .WithMessage("Đánh giá sao từ 1 đến 5");

            // ProductTierId
            RuleFor(x => x.ProductTierId)
                .NotNull()
                .GreaterThan(0);
        }
    }
}