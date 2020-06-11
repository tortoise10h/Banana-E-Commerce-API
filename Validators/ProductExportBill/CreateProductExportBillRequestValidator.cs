using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportBill;
using Banana_E_Commerce_API.Validators.ProductExportDetail;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.ProductExportBill
{
    public class CreateProductExportBillRequestValidator : AbstractValidator<CreateProductExportBillRequest>
    {
        public CreateProductExportBillRequestValidator()
        {
            // OrderId 
            RuleFor(x => x.OrderId)
                .NotEmpty();

            // ProductExportDetails
            RuleForEach(x => x.ProductExportDetails)
                .SetValidator(new CreateProductExportDetailRequestValidator());
        }
    }
}