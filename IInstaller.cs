using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Banana_E_Commerce_API
{
    public interface IInstaller
    {
        void InstallServices(IConfiguration configuration, IServiceCollection services);
    }
}