using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp21_BegginingEF.Entities;

namespace ConsoleApp21_BegginingEF.Configuration
{
    public class BlogConfig:EntityTypeConfiguration<Blog>
    {
        public BlogConfig()
        {
            HasKey(c => c.MyBlogIdentity);
            Property(c => c.BlogName).HasMaxLength(50).IsRequired();
            HasMany(c => c.Posts).WithRequired(c => c.Blog).HasForeignKey(c => c.BlogId).WillCascadeOnDelete(true);
        }
    }
}
