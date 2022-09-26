using EM.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EM.Service;

public static class ServicesCollectionExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IClienteService, ClienteService>();
        return services;
    }
}
