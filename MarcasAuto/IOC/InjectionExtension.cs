using MarcasAuto.Infraestructure.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace MarcasAuto.IOC
{
    public static class InjectionExtension
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            services.AddDbContext<MarcasAutoDBContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DBConnection"), b =>
                {
                    b.MigrationsAssembly("MarcasAuto");
                });
                options.EnableSensitiveDataLogging();
            });
            return services;
        }
    }
}
