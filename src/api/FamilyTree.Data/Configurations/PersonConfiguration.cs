using FamilyTree.Application.Entities;
using FamilyTree.Web.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyTree.Data.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Gender)
            .HasConversion<string>();

        SeedFamilies.SeedPersonData(builder);
    }
}
