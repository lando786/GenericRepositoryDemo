using GenericRepositoryDemo.Data;
using GenericRepositoryDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Repository
{
    public interface IPizzaRepository : IGenericRepository<Pizza>
    {
        //void AddPizza(Pizza pizza);
        //IEnumerable<Pizza> GetAll();
    }
    public class PizzaRepository : GenericRepository<Pizza>, IPizzaRepository
    {
        //private PizzaContext _context;
        //private DbSet<Pizza> table = null;
        public PizzaRepository(IPizzaContextFactory pizzaContextFactory) : base(pizzaContextFactory)
        {
        }

        //public void AddPizza(Pizza pizza)
        //{
        //    table.Add(pizza);
        //    _context.SaveChanges();
        //}

        //public IEnumerable<Pizza> GetAll()
        //{
        //    return table.ToList();
        //}
    }
}
