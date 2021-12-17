using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RabbidsIncubator.LightApi.Infrastructure.MongoDb.Entities
{
    internal class Device : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string MacAddress { get; set; }
    }
}
