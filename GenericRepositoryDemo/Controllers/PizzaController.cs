using GenericRepositoryDemo.Models;
using GenericRepositoryDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController
    {
        private IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            return _pizzaService.GetPizzas();
        }

        [HttpPost]
        public void AddPizza(Pizza pizza)
        {
            _pizzaService.AddPizza(pizza);
        }

    }
}
