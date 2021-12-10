using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Domain
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }

        public PizzaContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>

            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Pizza;Integrated Security=True;");
    }
}
