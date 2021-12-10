using GenericRepositoryDemo.Models;
using GenericRepositoryDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Pizza>>> Get()
        {
            var result = await _pizzaService.GetPizzas();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Pizza>> AddPizza(Pizza pizza)
        {
            var result =  await _pizzaService.AddPizza(pizza);
            return Ok(result);
        }

    }
}
