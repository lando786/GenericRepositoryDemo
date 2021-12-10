using GenericRepositoryDemo.Models;

namespace GenericRepositoryDemo.Data
{
    public interface IPizzaContextFactory
    {
        PizzaContext CreateContext();
    }
    public class PizzaContextFactory : IPizzaContextFactory
    {
        public PizzaContext CreateContext()
        {
            return new PizzaContext();
        }
    }
}
