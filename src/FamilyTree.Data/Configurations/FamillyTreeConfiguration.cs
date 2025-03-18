using FamilyTree.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyTree.Data.Configurations;

class FamilyTreeConfiguration : IEntityTypeConfiguration<Family>
{
    public void Configure(EntityTypeBuilder<Family> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
           .HasMany(x => x.Members)
           .WithOne()
           .HasForeignKey(x => x.FamilyId);

        var familyId = Guid.Parse("0a0a041f-dbf7-46bc-92e2-825d07d92d3c");

        builder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Smith Family Tree",
            });
    }
}
