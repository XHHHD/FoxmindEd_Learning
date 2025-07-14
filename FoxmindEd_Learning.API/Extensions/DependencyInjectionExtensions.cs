using FoxmindEd_Learning.API.Abstractions.Repositories;
using FoxmindEd_Learning.API.Abstractions.Services;
using FoxmindEd_Learning.API.Repositories;
using FoxmindEd_Learning.API.Services;

namespace FoxmindEd_Learning.API.Extensions;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection FE_AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IExampleEntityRepository, ExampleEntityRepository>();

        return services;
    }

    public static IServiceCollection FE_AddServices(this IServiceCollection services)
    {
        services.AddScoped<IExampleEntityService, ExampleEntityService>();

        return services;
    }
}
