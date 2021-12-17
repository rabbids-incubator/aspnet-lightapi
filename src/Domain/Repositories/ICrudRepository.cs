using System.Collections.Generic;
using System.Threading.Tasks;

namespace RabbidsIncubator.LightApi.Domain.Repositories
{
    public interface ICrudRepository<T>
    {
        Task<T> FindOneAsync(string id);

        Task<List<T>> FindAllAsync();

        Task<T> CreateAsync(T model);

        Task<long> UpdateAsync(string id, T model);

        Task<long> DeleteAsync(string id);
    }
}
