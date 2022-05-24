using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Core.Entities
{
    [Table("ASO_Customers", Schema = "ASO_BASE")]
    public class Customer: BaseHuman
    {
        public Guid CustomerUniqueGuid { get; set; }
    }
}
