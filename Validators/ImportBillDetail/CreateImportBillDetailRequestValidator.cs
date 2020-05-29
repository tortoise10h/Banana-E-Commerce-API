using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBillDetail;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.ImportBillDetail
{
    public class CreateImportBillDetailRequestValidator : AbstractValidator<CreateImportBillDetailRequest>
    {
        public CreateImportBillDetailRequestValidator()
        {
            // Quantity
            RuleFor(x => x.Quantity)
                .NotEmpty();

            // Price
            RuleFor(x => x.Price)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            // ProductTierId
            RuleFor(x => x.ProductTierId)
                .NotEmpty();
        }
    }
}