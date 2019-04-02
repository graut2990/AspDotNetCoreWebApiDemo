using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{     public static void ConfigureCors(this IServiceCollection services)
     {
        services.AddCors(options =>
        {
             options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
                );
        });
    }
    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
    {
      var connectionString = config["mysqlconnection:connectionString"];
      services.AddDbContext<DBRepositoryContext>(o => o.UseSqlServer(connectionString));

    }
    
 }