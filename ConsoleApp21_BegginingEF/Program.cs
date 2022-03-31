using ConsoleApp21_BegginingEF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21_BegginingEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BlogContext>());
            using(BlogContext ctx = new BlogContext())
            {
                var blogs = ctx.Blogs.ToList();
                foreach (var item in blogs)
                {
                    Console.WriteLine($"{item.BlogName}");
                }
                ctx.Blogs.Add(new Blog
                {

                });

                // Regular fetch
                var myBlog1 = ctx.Blogs.FirstOrDefault(c=>c.MyBlogIdentity == 1);

                // Enhanced fetch using First-Level cache
                var myBlog2 = ctx.Blogs.Find(1);
            }
            Console.ReadLine();
        }
    }
}
