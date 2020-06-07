using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTierTransferReport;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.ProductTierTransferReport
{
    public class CreateProductTierTransferReportRequestValidator : AbstractValidator<CreateProductTierTransferReportRequest>
    {
        public CreateProductTierTransferReportRequestValidator()
        {
            // Quantity
            RuleFor(x => x.Quantity)
                .NotEmpty();

            // FromTierId
            RuleFor(x => x.FromTierId)
                .NotEmpty();

            // ToTierId
            RuleFor(x => x.ToTierId)
                .NotEmpty();
        }
    }
}