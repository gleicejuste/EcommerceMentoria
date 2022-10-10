using EM.Service.Mappers;
using EM.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EM.Service;

public static class ServicesCollectionExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(RequestToDomainProfile));
        services.AddScoped<IClienteService, ClienteService>();
        return services;
    }
}
