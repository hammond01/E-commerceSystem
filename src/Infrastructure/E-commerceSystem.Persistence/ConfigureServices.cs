using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_commerceSystem.Persistence;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
