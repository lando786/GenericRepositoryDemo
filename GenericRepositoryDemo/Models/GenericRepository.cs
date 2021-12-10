using GenericRepositoryDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Models
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> Add(T obj);
        Task<bool> Update(T obj);
        Task Delete(object id);
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private PizzaContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository(IPizzaContextFactory cropPlanContext)
        {
            this._context = cropPlanContext.CreateContext();
            table = _context.Set<T>();
        }

        public virtual async Task<IList<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await table.FindAsync(id);
        }

        public virtual async Task<T> Add(T obj)
        {
            var newOrganiziation = await table.AddAsync(obj);
            await _context.SaveChangesAsync();
            return newOrganiziation.Entity;
        }

        public virtual async Task<bool> Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            return result == 1;
        }

        public virtual async Task Delete(object id)
        {
            T existing = await table.FindAsync(id);
            table.Remove(existing);
        }

    }
}
