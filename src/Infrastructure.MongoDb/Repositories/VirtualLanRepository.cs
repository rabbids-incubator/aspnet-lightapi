using System.Collections.Generic;
using System.Threading.Tasks;
using RabbidsIncubator.LightApi.Domain.Models;
using RabbidsIncubator.LightApi.Domain.Repositories;

namespace RabbidsIncubator.LightApi.Infrastructure.MongoDb.Repositories
{
    public class VirtualLanRepository : IVirtualLanRepository
    {
        public Task<List<DeviceModel>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<DeviceModel> FindOneAsync(int? number, string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
