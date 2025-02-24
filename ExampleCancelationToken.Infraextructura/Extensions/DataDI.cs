using ExampleCancelationToken.Domain.Repositories;
using ExampleCancelationToken.Infraextructura.Persistence.MysqlContext;
using ExampleCancelationToken.Infraextructura.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleCancelationToken.Infraextructura.Extensions
{
    public static class DataDI
    {

        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DbContext, ApplicationDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("Connection"),
                               ServerVersion.AutoDetect(configuration.GetConnectionString("Connection"))));
        }

        public static void MigrateDatabase(this IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                context.Database.Migrate();
            }
        }
    }
}
