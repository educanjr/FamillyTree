using FamilyTree.Application.Entities;
using FamilyTree.Application.Enums;
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

        var familyId = Guid.Parse("0a0a041f-dbf7-46bc-92e2-825d07d92d3c");
        var johnId = Guid.Parse("a2a5bcfe-da88-46e7-8439-d8f5ec85c474");
        var janeId = Guid.Parse("30e99d4d-4700-4c22-a1a3-ebdec1eb79b0");
        var robertId = Guid.Parse("69d3685a-3b75-4c32-86a0-1dfbb585c10a");
        var emmaId = Guid.Parse("5eeceddf-f9a2-4b7e-b236-2dba0000cdbf");

        builder.HasData(
            new Person
            {
                Id = johnId,
                GivenName = "John",
                Surname = "Smith",
                Gender = Gender.Male,
                BirthDate = new DateTime(1980, 5, 15),
                BirthLocation = "New York",
                DeathDate = null,
                DeathLocation = "",
                FamilyId = familyId,
            },
            new Person
            {
                Id = janeId,
                GivenName = "Jane",
                Surname = "Smith",
                Gender = Gender.Female,
                BirthDate = null,
                BirthLocation = "",
                DeathDate = new DateTime(2015, 8, 10),
                DeathLocation = "Los Angeles",
                FamilyId = familyId,
            },
            new Person
            {
                Id = robertId,
                GivenName = "Robert",
                Surname = "Brown",
                Gender = Gender.Male,
                BirthDate = new DateTime(1910, 3, 25),
                BirthLocation = "Chicago",
                DeathDate = null,
                DeathLocation = "",
                FamilyId = familyId,
            },
            new Person
            {
                Id = emmaId,
                GivenName = "Emma",
                Surname = "Johnson",
                Gender = Gender.Female,
                BirthDate = new DateTime(2020, 6, 15),
                BirthLocation = "Seattle",
                DeathDate = null,
                DeathLocation = "",
                FamilyId = familyId,
            });
    }
}
