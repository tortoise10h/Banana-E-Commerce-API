using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth;
using Banana_E_Commerce_API.Enums;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Auth
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            // Email
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            // Password
            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(8);

            // Name
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(255)
                .Matches(@"[a-zA-z]")
                    .WithMessage("Name only allow letter characters");

            // Phone
            RuleFor(x => x.Phone)
                .NotEmpty()
                .Matches(@"[0-9]")
                    .WithMessage("Your phone must be only contains number")
                .Length(10);

            // Gender
            List<Gender> validGenderValues = new List<Gender>() { Gender.Male, Gender.Female, Gender.Other };
            RuleFor(x => x.Gender)
                .NotEmpty()
                .Must(x => validGenderValues.Contains(x))
                    .WithMessage("Gender value is not valid");

        }
    }
}