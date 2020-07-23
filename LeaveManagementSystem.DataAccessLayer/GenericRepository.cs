
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.DataAccessLayer
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly LMSContext _context;
        private DbSet<T> entities;

        public GenericRepository(LMSContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return entities;
        }

        public async Task<T> GetById(int id)
        {
            return await entities.FindAsync(id);
        }

        public async Task Add(T t)
        {
            t.GetType().GetProperty("AddDate").SetValue(t, DateTime.Now);
            t.GetType().GetProperty("AddUser").SetValue(t, 1);
            await entities.AddAsync(t);
        }

        public async Task Update(T t)
        {
            t.GetType().GetProperty("ModDate").SetValue(t, DateTime.Now);
            t.GetType().GetProperty("ModUser").SetValue(t, 1);
             entities.Update(t);
        }

        public async Task<T> Delete(int id)
        {
            var entity = await GetById(id);
            entities.Remove(entity);
            return entity;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
