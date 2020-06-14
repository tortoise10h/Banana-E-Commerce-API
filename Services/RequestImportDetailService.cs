using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportDetail;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IRequestImportDetailService
    {
        Task<CreateRequestImportDetailResult> CreateAsync(RequestImportDetail requestImportDetail);
    }

    public class RequestImportDetailService : IRequestImportDetailService
    {
        private readonly DataContext _context;

        public RequestImportDetailService(
            DataContext context
        )
        {
            _context = context;
        }

        public async Task<CreateRequestImportDetailResult> CreateAsync(
            RequestImportDetail requestImportDetail)
        {
            var productTier = await _context.ProductTiers
                .Where(pt => pt.Id == requestImportDetail.ProductTierId &&
                    pt.IsDeleted == false)
                .Include(pt => pt.Product)
                .FirstOrDefaultAsync();
            if (productTier == null)
            {
                return new CreateRequestImportDetailResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Sản phẩm cần nhập hàng không tồn tại" }
                };
            }

            await _context.RequestImportDetails.AddAsync(requestImportDetail);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new CreateRequestImportDetailResult
                {
                    IsSuccess = false,
                    Errors = new[] {
                        $"Tạo yêu cầu nhập hàng cho sản phẩm {productTier.Product.Name} không thành công"
                    }
                };
            }

            return new CreateRequestImportDetailResult
            {
                IsSuccess = true,
                RequestImportDetail = requestImportDetail
            };
        }
    }
}