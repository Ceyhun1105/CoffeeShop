using CoffeeShop.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CoffeeShop.Persistence;

public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<CoffeeDbContext>
{
    public CoffeeDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<CoffeeDbContext> dbContext = new();
        dbContext.UseSqlServer(SqlConfiguration.SqlConnectionString);
        return new(dbContext.Options);
    }
}
