using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Core.Entities
{
    public class Customer: BaseEntity
    {
        public Guid CustomerUniqueGuid { get; set; }
    }
}
