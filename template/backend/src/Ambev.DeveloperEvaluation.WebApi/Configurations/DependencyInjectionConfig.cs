using Ambev.DeveloperEvaluation.Bus;
using Ambev.DeveloperEvaluation.IoC;

namespace Ambev.DeveloperEvaluation.WebApi.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this WebApplicationBuilder builder)
        {
            if (builder.Services == null) throw new ArgumentNullException(nameof(builder.Services));

            var rabbitMqSettings = builder.Configuration.GetSection("RabbitMqSettings").Get<RabbitMqSetting>();
            builder.Services.AddSingleton(rabbitMqSettings);

            builder.RegisterDependencies();
        }
    }
}
