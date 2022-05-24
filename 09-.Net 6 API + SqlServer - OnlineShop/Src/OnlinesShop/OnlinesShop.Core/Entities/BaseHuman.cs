using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Core.Entities
{
    public abstract class BaseHuman
    {
        [Key]
        public long Id { get; set; }
        
        [MaxLength(128), Required]
        public string FirstName { get; set; }
        
        [MaxLength(128), Required]
        public string? LastName { get; set; }
        public string SSN { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
