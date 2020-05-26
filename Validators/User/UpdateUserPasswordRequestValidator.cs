using Banana_E_Commerce_API.Contracts.V1.RequestModels.Users;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.User
{
    public class UpdateUserPasswordRequestValidator : AbstractValidator<UpdateUserPasswordRequest>
    {
        public UpdateUserPasswordRequestValidator()
        {
             // New password and confirm password
            RuleFor(x => x.newPassword)
                .NotEmpty()
                .MinimumLength(8);

            RuleFor(x => x.confirmPassword)
                .NotEmpty()
                .MinimumLength(8);
        }
    }
}