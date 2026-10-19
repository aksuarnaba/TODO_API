using Microsoft.EntityFrameworkCore;
using Todo.Infastructure.Persistence.Entities;

namespace Todo.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfastructure(
            this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString
                = configuration.GetConnectionString("DatabaseConnection");

            services.AddDbContext<TodoAppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}
