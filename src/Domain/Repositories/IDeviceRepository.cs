using System.Collections.Generic;
using System.Threading.Tasks;
using RabbidsIncubator.LightApi.Domain.Models;

namespace RabbidsIncubator.LightApi.Domain.Repositories
{
    public interface IDeviceRepository
    {
        Task<DeviceModel> FindOneAsync(string macAddress);

        Task<List<DeviceModel>> FindAllAsync();
    }
}
