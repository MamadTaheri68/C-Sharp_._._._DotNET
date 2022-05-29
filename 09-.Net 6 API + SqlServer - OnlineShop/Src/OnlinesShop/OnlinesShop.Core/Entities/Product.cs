using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Core.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
    }
}
