using RP.Domain.Entities;

namespace RP.Application.Interfaces
{
    public interface IStoreRepository 
    {
        Task<IReadOnlyList<Store>> GetAllAsync();
        Task<Store> GetByIdAsync(int id);
        Task<Store> AddAsync(Store entity);
        Task<Store> UpdateAsync(Store entity);
        Task DeleteAsync(Store entity);

    }
}
