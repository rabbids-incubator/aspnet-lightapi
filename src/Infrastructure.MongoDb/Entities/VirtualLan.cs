using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RabbidsIncubator.LightApi.Infrastructure.MongoDb.Entities
{
    public class VirtualLan
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public int Number { get; set; }
    }
}
