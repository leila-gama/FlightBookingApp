using FlightBookingApp.Core.Data;
using FlightBookingApp.Identity.Data.Context;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlightBookingApp.Identity.Extensions
{
    public static class MigrationsExtensions
    {
        public static IApplicationBuilder UseMigrations(this IApplicationBuilder app)
        {
            MigrateDatabase(app.ApplicationServices);
            SeedData(app.ApplicationServices);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<FlightBookingApp.Identity.Data.Context.IdentityDbContext>();
            context.Database.Migrate();
        }

        private static void SeedData(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var seeders = scope.ServiceProvider.GetServices<IDataSeeder>();
            foreach (var seeder in seeders)
            {
                seeder.SeedAllAsync().GetAwaiter().GetResult();
            }
        }
    }
}
