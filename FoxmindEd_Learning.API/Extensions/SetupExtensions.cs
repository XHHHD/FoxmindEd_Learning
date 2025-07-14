using FoxmindEd_Learning.API.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace FoxmindEd_Learning.API.Extensions;

public static class SetupExtensions
{
    public static IServiceCollection FE_SetupDB(this IServiceCollection services)
    {
        services.AddDbContext<FE_DbContext>(options => options.UseInMemoryDatabase("FE_InMemoryDb"));

        return services;
    }
}
