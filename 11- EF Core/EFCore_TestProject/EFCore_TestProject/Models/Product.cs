namespace EFCore_TestProject.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public bool IsInStock { get; set; }
        public DateTime CreationDate { get; set; }

        public Product(string name, double unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
            IsInStock = true;
            CreationDate = DateTime.Now;
        }
    }
}
