using GenericRepositoryDemo.Data;
using GenericRepositoryDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Repository
{
    public interface IPizzaRepository
    {
        void AddPizza(Pizza pizza);
        IEnumerable<Pizza> GetAll();
    }
    public class PizzaRepository : IPizzaRepository
    {
        private PizzaContext _context;
        private DbSet<Pizza> table = null;
        public PizzaRepository(IPizzaContextFactory pizzaContextFactory)
        {
            _context = pizzaContextFactory.CreateContext();
            table = _context.Set<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            table.Add(pizza);
            _context.SaveChanges();
        }

        public IEnumerable<Pizza> GetAll()
        {
            return table.ToList();
        }
    }
}
