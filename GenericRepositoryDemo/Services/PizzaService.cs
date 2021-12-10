using GenericRepositoryDemo.Models;
using GenericRepositoryDemo.Repository;

namespace GenericRepositoryDemo.Services
{
    public interface IPizzaService
    {
        void AddPizza(Pizza pizza);
        IEnumerable<Pizza> GetPizzas();

    }
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public void AddPizza(Pizza pizza)
        {
            _pizzaRepository.AddPizza(pizza);
        }

        public IEnumerable<Pizza> GetPizzas()
        {
            return _pizzaRepository.GetAll();
        }
    }
}
