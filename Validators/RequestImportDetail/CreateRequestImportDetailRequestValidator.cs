using Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportDetail;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.RequestImportDetail
{
    public class CreateRequestImportDetailRequestValidator : AbstractValidator<CreateRequestImportDetailRequest>
    {
        public CreateRequestImportDetailRequestValidator()
        {
            // ProductTierId
            RuleFor(x => x.ProductTierId)
                .NotEmpty();

            //  Quantity
            RuleFor(x => x.Quantity)
                .NotEmpty();
        }
    }
}