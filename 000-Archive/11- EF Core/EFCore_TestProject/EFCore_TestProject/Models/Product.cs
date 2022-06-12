using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_TestProject.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public bool IsInStock { get; set; }
        public int DiscountRate { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsRemoved { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }

        public Product(string name, double unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
            IsInStock = true;
            DiscountRate = 0;
            CreationDate = DateTime.Now;
        }

        public void SetDiscountRate(int rate)
        {
            this.DiscountRate = rate;
        }
    }
}
