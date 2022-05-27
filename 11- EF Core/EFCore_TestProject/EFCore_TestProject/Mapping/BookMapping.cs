using EFCore_TestProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_TestProject.Mapping
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);


        }
    }

    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
        }
    }

    public class BookCategoryMapping : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.ToTable("BookCategories");
            builder.HasKey(q => new { q.BookId, q.CategoryId});

            builder.HasOne(q => q.Book).WithMany(q => q.BookCategories).HasForeignKey(q => q.BookId);

            builder.HasOne(q => q.Category).WithMany(q => q.BookCategories).HasForeignKey(q => q.CategoryId);
        }
    }
}
