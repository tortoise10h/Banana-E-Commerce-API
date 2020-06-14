using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Product;
using Banana_E_Commerce_API.Enums;
using FluentValidation;

namespace Banana_E_Commerce_API.Validators.Product
{
    public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
    {
        public UpdateProductRequestValidator()
        {
            // Name
            RuleFor(x => x.Name)
                .MaximumLength(255);

            // Price Currency
            RuleFor(x => x.PriceCurrency)
                .IsInEnum()
                .WithMessage("Đơn vị tiền tệ không hợp lệ");

            // Product Unit
            RuleFor(x => x.ProductUnit)
                .IsInEnum()
                .WithMessage("Đơn vị bán không hợp lệ");

            // Status
            RuleFor(x => x.Status)
                .IsInEnum()
                .WithMessage("Trạng thái của sản phẩm không hợp lệ");

            // Origin
            RuleFor(x => x.Origin)
                .NotEmpty()
                .MaximumLength(255);
        }
    }
}