using System.Collections.Generic;
using System.Threading.Tasks;
using RabbidsIncubator.LightApi.Domain.Models;

namespace RabbidsIncubator.LightApi.Domain.Repositories
{
    public interface IVirtualLanRepository
    {
        Task<DeviceModel> FindOneAsync(int? number, string name);

        Task<List<DeviceModel>> FindAllAsync();
    }
}
