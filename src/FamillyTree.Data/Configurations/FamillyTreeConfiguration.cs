using FamillyTree.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamillyTree.Data.Configurations;

class FamillyTreeConfiguration : IEntityTypeConfiguration<Familly>
{
    public void Configure(EntityTypeBuilder<Familly> builder)
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
