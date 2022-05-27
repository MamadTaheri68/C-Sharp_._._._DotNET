using EFCore_TestProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_TestProject.Mapping
{
    public class AuthorBiographyMapping : IEntityTypeConfiguration<AuthorBiography>
    {
        public void Configure(EntityTypeBuilder<AuthorBiography> builder)
        {
            builder.ToTable("AuthorBiographies");
            builder.HasKey(x => x.Id);

        }
    }
}
