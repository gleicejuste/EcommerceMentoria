using EM.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace EM.Data;

public static class ServicesCollectionExtensions
{
    public static IServiceCollection AddData(this IServiceCollection services)
    {
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        return services;
    }
}
