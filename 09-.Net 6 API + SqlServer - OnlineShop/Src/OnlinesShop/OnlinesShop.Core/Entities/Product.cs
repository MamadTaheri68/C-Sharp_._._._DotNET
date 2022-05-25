using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Core.Entities
{
    [Table("ASO_Products", Schema = "ASO_BASE")]
    public class Product
    {
        [Key]
        public long Id { get; set; }
        
        //[MaxLength(128), Required]
        public string ProductName { get; set; }
        public long Price { get; set; }
    }
}
