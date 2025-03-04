using Ambev.DeveloperEvaluation.ORM.Options;
using Ambev.DeveloperEvaluation.ORM;
using Microsoft.Extensions.Options;
using System;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.WebApi.Configurations
{
    public static class DatabaseConfig
    {

        public static void AddDatabaseConfiguration(this WebApplicationBuilder builder)
        {
            if (builder.Services == null) throw new ArgumentNullException(nameof(builder.Services));

            builder.Services.AddDbContext<DefaultContext>(options =>
                options.UseNpgsql(
                    builder.Configuration.GetConnectionString("DefaultConnection")
                )
            );

            builder.Services.AddDbContext<EventStoreSqlContext>(options =>
                options.UseNpgsql(
                    builder.Configuration.GetConnectionString("DefaultConnection")
                )
            );

            builder.Services.Configure<MongoDatabaseSettings>(builder.Configuration.GetSection(nameof(MongoDatabaseSettings)));

            builder.Services.AddSingleton<IMongoDatabaseSettings>(sp => sp.GetRequiredService<IOptions<MongoDatabaseSettings>>().Value);
        }
        public static void CreateDatabaseIfNotExists(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DefaultContext>();
                var eventContext = serviceScope.ServiceProvider.GetRequiredService<EventStoreSqlContext>();
                var mongoContext = serviceScope.ServiceProvider.GetRequiredService<MongoSeeder>();
                
                context.Database.Migrate();
                eventContext.Database.Migrate();


                mongoContext.SeedAllAsync().GetAwaiter();
            }
        }
    }
}
