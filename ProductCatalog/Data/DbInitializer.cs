using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Data;

public static class DbInitializer
{
    public static void Initialize(IServiceProvider serviceProvider, bool isDevelopment = true)
    {
        using var scope = serviceProvider.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<ApplicationDbContext>();
        
        if (isDevelopment)
        {
            // Development: Recreate database to get latest schema
            // WARNING: This deletes all data!
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
        else
        {
            // Production: Use migrations to update schema
            // Preserves existing data
            context.Database.Migrate();
        }
        
        // Seed data if needed
        SeedData.Initialize(context);
    }
}

