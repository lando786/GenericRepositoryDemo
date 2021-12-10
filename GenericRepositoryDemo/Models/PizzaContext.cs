using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>

            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Pizza;Integrated Security=True;");
    }
}
