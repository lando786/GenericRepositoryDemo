namespace GenericRepositoryDemo.Models
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }
    }
}
