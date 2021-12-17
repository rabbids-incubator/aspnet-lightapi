using System.Collections.Generic;
using Withywoods.Dal.MongoDb;

namespace RabbidsIncubator.LightApi.Infrastructure.MongoDb
{
    public class InfrastructureMongoDbConfiguration : IMongoDbConfiguration
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public List<string> SerializationConventions { get; set; }
    }
}
