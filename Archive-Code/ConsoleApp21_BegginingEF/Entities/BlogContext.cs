using ConsoleApp21_BegginingEF.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21_BegginingEF.Entities
{
    public class BlogContext: DbContext
    {
        public BlogContext():base("cnn")
        {

        }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Approach1
            //modelBuilder.Entity<Blog>().HasKey(c => c.MyBlogIdentity);
            //modelBuilder.Entity<Blog>().Property(c => c.BlogName).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<Blog>().HasMany(c => c.Posts).WithRequired(c => c.Blog).HasForeignKey(c => c.BlogId);

            // Approach2
            //modelBuilder.Configurations.Add(new BlogConfig());
            //modelBuilder.Configurations.Add(new PostConfig());
            //modelBuilder.Configurations.Add(new AuthorConfig());
            
            // Approach3
            modelBuilder.Configurations.AddFromAssembly(this.GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
