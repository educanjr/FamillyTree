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

        //TODO: Seed data with HasValue method
    }
}
