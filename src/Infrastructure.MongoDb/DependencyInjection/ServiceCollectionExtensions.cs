using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace RabbidsIncubator.LightApi.Infrastructure.MongoDb.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureMongoDb(this IServiceCollection services, InfrastructureMongoDbConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddSingleton<Withywoods.Dal.MongoDb.IMongoDbConfiguration>(configuration);
            services.TryAddTransient<Withywoods.Dal.MongoDb.IMongoClientFactory, Withywoods.Dal.MongoDb.MongoClientFactory>();
            services.TryAddScoped<Withywoods.Dal.MongoDb.IMongoDbContext, Withywoods.Dal.MongoDb.DefaultMongoDbContext>();

            services.TryAddTransient<Domain.Repositories.IDeviceRepository, Repositories.DeviceRepository>();
            services.TryAddTransient<Domain.Repositories.IVirtualLanRepository, Repositories.VirtualLanRepository>();

            return services;
        }
    }
}
