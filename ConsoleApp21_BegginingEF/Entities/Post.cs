using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21_BegginingEF.Entities
{
    public class Post
    {
        public int PostId { get; set; }

        //[MaxLength(50)]
        public string Title { get; set; }
        public DateTime Date { get; set; }
        
        //[ForeignKey("BlogId")]
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
        public string PostText { get; set; }
    }
}
