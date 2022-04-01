using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21_BegginingEF.Entities
{
    public class Author
    {
        public int Id { get; set; }

        //[MaxLength(50)]
        public string FirstName { get; set; }

        //[MaxLength(50)]
        public string LastName { get; set; }

        //[InverseProperty("Author01")]
        public List<Blog> BlogsAsAuthor01 { get; set; }

        //[InverseProperty("Author02")]
        //public List<Blog> BlogsAsAuthor02 { get; set; }
    }


    [Table("tblBlog",Schema ="blogSystem")]
    public class Blog
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MyBlogIdentity { get; set; }

        //[MinLength(3,ErrorMessage ="حداقل طول مجاز 3 کاراکتر می باشد.")]
        //[MaxLength(50, ErrorMessage ="حداکثر طول 50 کاراکتر می باشد.")]
        //[Required(ErrorMessage ="برای نام بلاگ مقدار اجباری است.")]
        //[Column(Order =4)]
        //[ConcurrencyCheck]
        public string BlogName { get; set; }
        
        public Author Author01 { get; set; }
        //public Author Author02 { get; set; }
        public List<Post> Posts { get; set; }
        
        //[Timestamp]
        //public byte[] RowVersion { get; set; }
    }
}
