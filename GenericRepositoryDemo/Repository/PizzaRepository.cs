using GenericRepositoryDemo.Data;
using GenericRepositoryDemo.Models;


namespace GenericRepositoryDemo.Repository
{
    public interface IPizzaRepository : IGenericRepository<Pizza>
    {
       
    }
    public class PizzaRepository : GenericRepository<Pizza>, IPizzaRepository
    {
       
        public PizzaRepository(IPizzaContextFactory pizzaContextFactory) : base(pizzaContextFactory)
        {
        }

        public void SpecialPizzaMethod()
        {
        }
    }
}
