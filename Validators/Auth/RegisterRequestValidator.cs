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
                    .WithMessage("Tên chỉ cho phép các kí tự chữ cái");

            // Phone
            RuleFor(x => x.Phone)
                .NotEmpty()
                .Matches(@"[0-9]")
                    .WithMessage("Số điện thoại chỉ cho phép chứa số")
                .Length(10);

            // Gender
            List<Gender> validGenderValues = new List<Gender>() { Gender.Male, Gender.Female, Gender.Other };
            RuleFor(x => x.Gender)
                .NotNull()
                .Must(x => validGenderValues.Contains(x))
                    .WithMessage("Giới tính không hợp lệ");

        }
    }
}