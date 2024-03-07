using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace E_commerceSystem.Application;
public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(h =>
        {
            h.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
        });
        return services;
    }
}
