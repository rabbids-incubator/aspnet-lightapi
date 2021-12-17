using System.Collections.Generic;
using System.Threading.Tasks;
using RabbidsIncubator.LightApi.Domain.Models;

namespace RabbidsIncubator.LightApi.Domain.Repositories
{
    public interface IDeviceRepository<T> : ICrudRepository<T>
    {
        new Task<DeviceModel> FindOneAsync(string macAddress);
        new Task<List<DeviceModel>> FindAllAsync();
    }
}
