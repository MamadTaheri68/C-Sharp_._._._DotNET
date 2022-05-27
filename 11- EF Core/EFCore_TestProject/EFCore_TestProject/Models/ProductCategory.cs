namespace EFCore_TestProject.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public ProductCategory(string name)
        {
            Name = name;
            Products = new List<Product>();
        }
    }
}
