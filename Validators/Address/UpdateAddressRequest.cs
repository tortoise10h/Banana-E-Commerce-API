using Banana_E_Commerce_API.Contracts.V1.RequestModels.Address;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Address
{
    public class UpdateAddressRequestValidator : AbstractValidator<UpdateAddressRequest>
    {
        public UpdateAddressRequestValidator()
        {
            // City
            RuleFor(x => x.City)
                .MaximumLength(255);
            
            // District
            RuleFor(x => x.District)
                .MaximumLength(255);

            // Ward
            RuleFor(x => x.Ward)
                .MaximumLength(255);
            
            // StreetLocation
            RuleFor(x => x.StreetLocation)
                .MaximumLength(255);
            
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
        }
    }
}