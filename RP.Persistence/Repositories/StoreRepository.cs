using Microsoft.EntityFrameworkCore;
using RP.Application.Interfaces;
using RP.Domain.Entities;
using RP.Persistence.Context;

namespace RP.Persistence.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private DatabaseDbContext _context;

        public StoreRepository(DatabaseDbContext context)
        {
            _context = context;
        }

        public async Task<Store> GetByIdAsync(int id)
        {
            return await _context.Stores.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Store> AddAsync(Store entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Store> UpdateAsync(Store entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Store entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Store>> GetAllAsync()
        {
           return await _context.Stores.ToListAsync();
        }

    
    }
}
