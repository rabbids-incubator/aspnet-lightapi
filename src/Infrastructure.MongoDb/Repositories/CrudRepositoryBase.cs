using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using RabbidsIncubator.LightApi.Infrastructure.MongoDb.Entities;
using Withywoods.Dal.MongoDb;

namespace RabbidsIncubator.LightApi.Infrastructure.MongoDb.Repositories
{
    public abstract class CrudRepositoryBase<T, U> : Withywoods.Dal.MongoDb.Repositories.RepositoryBase where U : IEntity
    {
        protected CrudRepositoryBase(IMongoDbContext mongoDbContext, ILogger<CrudRepositoryBase<T, U>> logger, IMapper mapper)
            : base(mongoDbContext, logger, mapper)
        {
        }

        public async Task<T> FindOneAsync(string id)
        {
            var objectId = ParseObjectId(id);
            var collection = GetCollection<U>();
            var dbEntries = await collection.FindAsync(x => x.Id == objectId);
            return Mapper.Map<T>(dbEntries.FirstOrDefault());
        }

        public async Task<List<T>> FindAllAsync()
        {
            var collection = GetCollection<U>();
            var dbEntries = await collection.FindAsync(new BsonDocument());
            return Mapper.Map<List<T>>(dbEntries.ToList());
        }

        public async Task<T> CreateAsync(T model)
        {
            var collection = GetCollection<U>();
            var entity = Mapper.Map<U>(model);
            await collection.InsertOneAsync(entity);
            return Mapper.Map<T>(entity);
        }

        public async Task<long> UpdateAsync(string id, T model)
        {
            var objectId = ParseObjectId(id);
            var collection = GetCollection<U>();
            var entity = Mapper.Map<U>(model);
            var result = await collection.ReplaceOneAsync(x => x.Id == objectId, entity);
            return result.ModifiedCount;
        }

        public async Task<long> DeleteAsync(string id)
        {
            var objectId = ParseObjectId(id);
            var collection = GetCollection<U>();
            var result = await collection.DeleteOneAsync(x => x.Id == objectId);
            return result.DeletedCount;
        }

        protected static ObjectId ParseObjectId(string id, string message = "")
        {
            if (string.IsNullOrEmpty(id) || !ObjectId.TryParse(id, out var objectId))
            {
                throw new ArgumentException($"{message}{id} is not a valid id.", nameof(id));
            }

            return objectId;
        }
    }
}
