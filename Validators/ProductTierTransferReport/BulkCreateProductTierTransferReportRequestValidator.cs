using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTierTransferReport;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.ProductTierTransferReport
{
    public class BulkCreateProductTierTransferReportRequestValidator : AbstractValidator<BulkCreateProductTierTransferReportRequest>
    {
        public BulkCreateProductTierTransferReportRequestValidator()
        {
            // productTierTransferReports
            RuleForEach(x => x.productTierTransferReports)
                .SetValidator(new CreateProductTierTransferReportRequestValidator());
        }
    }
}