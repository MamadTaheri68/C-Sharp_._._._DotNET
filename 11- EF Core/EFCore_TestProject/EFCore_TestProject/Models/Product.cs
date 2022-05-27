using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_TestProject.Models
{
    [Table("MyProducts", Schema = "ASO_SHOP")]
    public class Product
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        [MinLength(1)]
        [MaxLength(255)]
        public string Name { get; set; }
        
        public double UnitPrice { get; set; }
        
        public bool IsInStock { get; set; }
        
        public int DiscountRate { get; set; }
        
        [Column("IsDeletedByUser")]
        public bool IsRemoved { get; set; }
        
        public DateTime CreationDate { get; set; }

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
