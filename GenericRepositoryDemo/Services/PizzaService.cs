using GenericRepositoryDemo.Models;
using GenericRepositoryDemo.Repository;

namespace GenericRepositoryDemo.Services
{
    public interface IPizzaService
    {
        Task<Pizza> AddPizza(Pizza pizza);
        Task<IList<Pizza>> GetPizzas();

    }
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public async Task<Pizza> AddPizza(Pizza pizza)
        {
            return await _pizzaRepository.Add(pizza);
        }

        public async Task<IList<Pizza>> GetPizzas()
        {
            return await _pizzaRepository.GetAll();
        }
    }
}
