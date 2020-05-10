using Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Auth
{
    public class AuthenticateRequestValidator : AbstractValidator<AuthenticateRequest>
    {
        public AuthenticateRequestValidator()
        {
            // Email
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            // Password
            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(8);
        }
    }
}