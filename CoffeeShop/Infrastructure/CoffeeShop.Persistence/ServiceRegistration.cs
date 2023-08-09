using CoffeeShop.Domain.Entities;
using CoffeeShop.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceService(this IServiceCollection services)
    {
        services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<CoffeeDbContext>().AddDefaultTokenProviders();
        
        services.AddDbContext<CoffeeDbContext>(opt =>
        {
            opt.UseSqlServer(SqlConfiguration.SqlConnectionString);
        });
    }
}
