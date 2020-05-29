using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBill;
using Banana_E_Commerce_API.Validators.ImportBillDetail;
using Banana_E_Commerce_API.Validators.ProductImage;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.ImportBill
{
    public class CreateImportBillRequestValidator : AbstractValidator<CreateImportBillRequest>
    {
        public CreateImportBillRequestValidator()
        {
            // RequestImportProductId
            RuleFor(x => x.RequestImportProductId)
                .NotEmpty();

            // SupplierBillImage
            RuleFor(x => x.SupplierBillImage)
                .SetValidator(new ImageUploadValidator());

            // StorageManagerBillImage
            RuleFor(x => x.StorageManagerBillImage)
                .SetValidator(new ImageUploadValidator());

            // ImportBillDetails
            RuleForEach(x => x.ImportBillDetails)
                .SetValidator(new CreateImportBillDetailRequestValidator());
        }
    }
}