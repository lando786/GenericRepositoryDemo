using GenericRepositoryDemo.Models;
using GenericRepositoryDemo.Repository;

namespace GenericRepositoryDemo.Services
{
    public interface IPizzaService
    {
        Task<Pizza> AddPizza(Pizza pizza);
        Task<IList<Pizza>> GetPizzas();
        //Task<Pizza> GetPizza(Guid id);
        //Task UpdatePizza(Pizza pizza);

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

        //public async Task<Pizza> GetPizza(Guid id)
        //{
        //    return await _pizzaRepository.GetById(id);
        //}

        public async Task<IList<Pizza>> GetPizzas()
        {
            return await _pizzaRepository.GetAll();
        }

        //public async Task UpdatePizza(Pizza pizza)
        //{
        //    await _pizzaRepository.Update(pizza);
        //}
    }
}
