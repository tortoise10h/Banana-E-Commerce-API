using Banana_E_Commerce_API.Contracts.V1.RequestModels.Rating;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Rating
{
    public class UpdateRatingRequestValidator : AbstractValidator<UpdateRatingRequest>
    {
        public UpdateRatingRequestValidator()
        {
            // Comment
            RuleFor(x => x.Comment)
                .MaximumLength(5000);

            // StarNum
            RuleFor(x => x.StarNum)
                .NotNull()
                .InclusiveBetween(1, 5)
                .WithMessage("Đánh giá sao từ 1 đến 5");
        }
    }
}