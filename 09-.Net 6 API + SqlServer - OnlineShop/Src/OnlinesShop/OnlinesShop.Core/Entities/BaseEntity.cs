using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string SSN { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
