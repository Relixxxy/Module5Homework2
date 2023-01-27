namespace Catalog.Host.Models
{
    public class Product
    {
        public Product(int id, string name, string category)
        {
            Id = id;
            Name = name;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
