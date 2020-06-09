using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Banana_E_Commerce_API.Installers
{
    public class BusinessServicesInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IStorageService, StorageService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICartDetailService, CartDetailService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IProductImageService, ProductImageService>();
            services.AddScoped<IProductTierService, ProductTierService>();
            services.AddScoped<ITierService, TierService>();
            services.AddScoped<IRequestImportProductService, RequestImportProductService>();
            services.AddScoped<IRequestImportDetailService, RequestImportDetailService>();
            services.AddScoped<IImportBillService, ImportBillService>();
            services.AddScoped<IUploadImageService, UploadImageService>();
            services.AddScoped<IStorageManagerService, StorageManagerService>();
            services.AddScoped<IProductFavorService, ProductFavorService>();
            services.AddScoped<IProductTierTransferReportService, ProductTierTransferReportService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IRatingImageService, RatingImageService>();

            services.AddSingleton<IUriService>(provider =>
            {
                var accessor = provider.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var absoluteUri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent(), "/");
                return new UriService(absoluteUri);
            });
        }
    }
}