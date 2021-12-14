using GenericRepositoryDemo.Data;
using GenericRepositoryDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Repository
{
    public interface IPizzaRepository// : IGenericRepository<Pizza>
    {
        Task<Pizza> Add(Pizza pizza);

        Task<IList<Pizza>> GetAll();
    }

    public class PizzaRepository : IPizzaRepository // GenericRepository<Pizza>, IPizzaRepository
    {
        private PizzaContext _context;
        private DbSet<Pizza> table = null;

        public PizzaRepository(IPizzaContextFactory pizzaContextFactory)// : base(pizzaContextFactory)
        {
            _context = pizzaContextFactory.CreateContext();
            table = _context.Set<Pizza>();
        }

        public async Task<Pizza> Add(Pizza pizza)
        {
            var newpizza = await table.AddAsync(pizza);
            await _context.SaveChangesAsync();
            return newpizza.Entity;
        }

        public async Task<IList<Pizza>> GetAll()
        {
            return await table.ToListAsync();
        }
    }
}