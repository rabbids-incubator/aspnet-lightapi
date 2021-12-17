using MongoDB.Bson;

namespace RabbidsIncubator.LightApi.Infrastructure.MongoDb.Entities
{
    public interface IEntity
    {
        ObjectId Id { get; set; }
    }
}
