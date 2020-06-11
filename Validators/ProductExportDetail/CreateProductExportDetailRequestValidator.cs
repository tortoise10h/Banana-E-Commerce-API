using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportDetail;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.ProductExportDetail
{
    public class CreateProductExportDetailRequestValidator : AbstractValidator<CreateProductExportDetailRequest>
    {
        public CreateProductExportDetailRequestValidator()
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