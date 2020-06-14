using Banana_E_Commerce_API.Contracts.V1.RequestModels.Customer;
using FluentValidation;
using Banana_E_Commerce_API.Enums;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Validators.Customer
{
    public class UpdateCustomerInfoRequestValidator : AbstractValidator<UpdateCustomerInfoRequest>
    {
        public UpdateCustomerInfoRequestValidator()
        {
            // Name
            RuleFor(x => x.Name)
                .MaximumLength(255)
                .Matches(@"[a-zA-z]")
                    .WithMessage("Tên chỉ cho phép các kí tự chữ cái");

            // Phone
            RuleFor(x => x.Phone)
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