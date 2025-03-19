using FamilyTree.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FamilyTree.Application.Enums;

namespace FamilyTree.Web.Seeders;

internal static class SeedFamilies
{
    private const string FirstFamilyId = "0a0a041f-dbf7-46bc-92e2-825d07d92d3c";
    private const string JohnsonFamilyId = "a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43";
    private const string SmithFamilyId = "b1a8e62d-4499-4f34-8773-b9fa4e7d2c43";
    private const string WilliamsFamilyId = "f2a19d5c-3b4e-4d92-8827-6f5b2e34c812";
    private const string BrownFamilyId = "a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1";
    private const string GonzalezFamilyId = "c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81";
    private const string BagginsFamilyId = "a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64";
    private const string PotterFamilyId = "b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6";
    private const string AtreidesFamilyId = "c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81";
    public static void SeedFamilyData(EntityTypeBuilder<Family> familyBuilder)
    {
        SeedFirstFamily(familyBuilder);
        SeedJohnsonFamily(familyBuilder);
        SeedSmithFamily(familyBuilder);
        SeedWilliamsFamily(familyBuilder);
        SeedBrownFamily(familyBuilder);
        SeedGonzalezFamily(familyBuilder);
        SeedBagginsFamily(familyBuilder);
        SeedPotterFamily(familyBuilder);
        SeedAtreidesFamily(familyBuilder);
    }

    public static void SeedPersonData(EntityTypeBuilder<Person> personBuilder)
    {
        SeedFirstFamilyMembers(personBuilder);
        SeedJohnsonFamilyMembers(personBuilder);
        SeedSmithFamilyMembers(personBuilder);
        SeedWilliamsFamilyMembers(personBuilder);
        SeedBrownFamilyMembers(personBuilder);
        SeedGonzalezFamilyMembers(personBuilder);
        SeedBagginsFamilyMembers(personBuilder);
        SeedPotterFamilyMembers(personBuilder);
        SeedAtreidesFamilyMembers(personBuilder);
    }

    private static void SeedFirstFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(FirstFamilyId);

        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Smith Family Tree",
            });
    }

    private static void SeedJohnsonFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(JohnsonFamilyId);
        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Johnson Family"
            });
    }

    private static void SeedSmithFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(SmithFamilyId);
        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Smith Family"
            });
    }

    private static void SeedWilliamsFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(WilliamsFamilyId);
        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Williams Family"
            });
    }

    private static void SeedBrownFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(BrownFamilyId);
        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Brown Family"
            });
    }

    private static void SeedGonzalezFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(GonzalezFamilyId);
        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Gonzalez Family"
            });
    }

    private static void SeedBagginsFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(BagginsFamilyId);
        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Baggins Family"
            });
    }

    private static void SeedPotterFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(PotterFamilyId);
        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Potter Family"
            });
    }

    private static void SeedAtreidesFamily(EntityTypeBuilder<Family> familyBuilder)
    {
        var familyId = Guid.Parse(AtreidesFamilyId);
        familyBuilder.HasData(
            new Family
            {
                Id = familyId,
                Name = "Atreides Family"
            });
    }



    private static void SeedFirstFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(FirstFamilyId);

        var johnId = Guid.Parse("a2a5bcfe-da88-46e7-8439-d8f5ec85c474");
        var janeId = Guid.Parse("30e99d4d-4700-4c22-a1a3-ebdec1eb79b0");
        var robertId = Guid.Parse("69d3685a-3b75-4c32-86a0-1dfbb585c10a");
        var emmaId = Guid.Parse("5eeceddf-f9a2-4b7e-b236-2dba0000cdbf");

        personBuilder.HasData(
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

    private static void SeedJohnsonFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(JohnsonFamilyId);
        personBuilder.HasData(
            new Person
            {
                Id = Guid.Parse("b7a63c14-9273-4cc5-ae35-ff8e8f43b8c2"),
                GivenName = "Robert",
                Surname = "Johnson",
                Gender = Gender.Male,
                BirthDate = new DateTime(1875, 2, 12),
                BirthLocation = "Los Angeles",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("5e345c48-8a73-40cd-bff8-b92c8d3758c5"),
                GivenName = "Linda",
                Surname = "Johnson",
                Gender = Gender.Female,
                BirthDate = new DateTime(1977, 11, 5),
                BirthLocation = "Los Angeles",
                DeathDate = new DateTime(2024, 12, 4),
                DeathLocation = "Los Angeles",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("27c74ac5-ec57-4bc8-8fa9-6c1d82767f6d"),
                GivenName = "Sophia",
                Surname = "Johnson",
                Gender = Gender.Female,
                BirthDate = new DateTime(2005, 4, 23),
                BirthLocation = "Los Angeles",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("8a97b09d-23c4-4fc8-8c02-d75284b2cf63"),
                GivenName = "Ethan",
                Surname = "Johnson",
                Gender = Gender.Male,
                BirthDate = new DateTime(2008, 9, 15),
                BirthLocation = "Los Angeles",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("be42f68b-57f2-4721-8dc5-6d0c2fb2c8de"),
                GivenName = "Oliver",
                Surname = "Johnson",
                Gender = Gender.Male,
                BirthDate = new DateTime(2011, 6, 30),
                BirthLocation = "Los Angeles",
                FamilyId = familyId,
            });
    }

    private static void SeedSmithFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(SmithFamilyId);

        personBuilder.HasData(
            new Person
            {
                Id = Guid.Parse("c4a76f38-5f77-499e-a1f1-65726b2e3f3d"),
                GivenName = "Michael",
                Surname = "Smith",
                Gender = Gender.Male,
                BirthDate = new DateTime(1945, 8, 15),
                BirthLocation = "New York",
                DeathDate = new DateTime(2020, 4, 10),
                DeathLocation = "New York",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("d3b57f28-3a88-4e02-bb36-2283f2b4d4a9"),
                GivenName = "Sarah",
                Surname = "Smith",
                Gender = Gender.Female,
                BirthDate = new DateTime(1948, 10, 3),
                BirthLocation = "New York",
                DeathDate = new DateTime(2021, 5, 19),
                DeathLocation = "New York",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("e5d79a14-92a7-4f92-81b2-6f3d38f66d99"),
                GivenName = "Emily",
                Surname = "Smith",
                Gender = Gender.Female,
                BirthDate = new DateTime(1970, 1, 25),
                BirthLocation = "New York",
                DeathDate = new DateTime(2018, 11, 9),
                DeathLocation = "New York",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("f872bfc3-99b7-4fd2-8715-3b6e2d42f887"),
                GivenName = "Jack",
                Surname = "Smith",
                Gender = Gender.Male,
                BirthDate = new DateTime(1972, 6, 8),
                BirthLocation = "New York",
                DeathDate = new DateTime(2015, 8, 22),
                DeathLocation = "New York",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("a9b63c14-9273-4cc5-ae35-ff8e8f43b8c2"),
                GivenName = "Lucas",
                Surname = "Smith",
                Gender = Gender.Male,
                BirthDate = new DateTime(2005, 3, 17),
                BirthLocation = "New York",
                DeathDate = new DateTime(2022, 6, 13),
                DeathLocation = "New York",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("b4c98e39-71d6-42d8-b185-3e3d21b5e5f2"),
                GivenName = "Grace",
                Surname = "Smith",
                Gender = Gender.Female,
                BirthDate = new DateTime(2009, 12, 5),
                BirthLocation = "New York",
                DeathDate = new DateTime(2023, 9, 17),
                DeathLocation = "New York",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("c6f87b24-51b7-4e72-91c2-4f3d38f66d22"),
                GivenName = "Ethan",
                Surname = "Smith",
                Gender = Gender.Male,
                BirthDate = new DateTime(2012, 4, 23),
                BirthLocation = "New York",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("d972cfc3-71c7-4fd2-9925-5b6e2d42f777"),
                GivenName = "Madison",
                Surname = "Smith",
                Gender = Gender.Female,
                BirthDate = new DateTime(2016, 9, 11),
                BirthLocation = "New York",
                FamilyId = familyId,
            }
        );
    }

    private static void SeedWilliamsFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(WilliamsFamilyId);

        personBuilder.HasData(
            new Person
            {
                Id = Guid.Parse("a72b9f31-5c44-4f02-bd9a-3e7f2a6d1e59"),
                GivenName = "Richard",
                Surname = "Williams",
                Gender = Gender.Male,
                BirthDate = new DateTime(1940, 5, 18),
                BirthLocation = "Chicago",
                DeathDate = new DateTime(2010, 3, 24),
                DeathLocation = "Chicago",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("d4c79b12-8f25-4e91-9726-5f2d71a3b64e"),
                GivenName = "Margaret",
                Surname = "Williams",
                Gender = Gender.Female,
                BirthDate = new DateTime(1944, 7, 9),
                BirthLocation = "Chicago",
                DeathDate = new DateTime(2015, 6, 2),
                DeathLocation = "Chicago",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("f81a72c4-9e38-41b5-95d2-3c6d87f2b3e1"),
                GivenName = "David",
                Surname = "Williams",
                Gender = Gender.Male,
                BirthDate = new DateTime(1968, 9, 22),
                BirthLocation = "Chicago",
                DeathDate = new DateTime(2020, 1, 15),
                DeathLocation = "Chicago",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("c9b6d4a1-52f3-4e92-b1c7-7e5f21d38a6b"),
                GivenName = "Linda",
                Surname = "Williams",
                Gender = Gender.Female,
                BirthDate = new DateTime(1971, 3, 30),
                BirthLocation = "Chicago",
                DeathDate = new DateTime(2022, 11, 8),
                DeathLocation = "Chicago",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("9a969a1e-a161-4727-9f4d-bc7a68fd6b87"),
                GivenName = "Sophia",
                Surname = "Williams",
                Gender = Gender.Female,
                BirthDate = new DateTime(1999, 2, 12),
                BirthLocation = "Chicago",
                DeathDate = new DateTime(2023, 5, 19),
                DeathLocation = "Chicago",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("b9d4e72a-5c6f-48f1-9123-7d38f21b5e74"),
                GivenName = "Daniel",
                Surname = "Williams",
                Gender = Gender.Male,
                BirthDate = new DateTime(2002, 6, 8),
                BirthLocation = "Chicago",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("c81b72d4-6e93-41f2-81d5-3f2a6c87b5e2"),
                GivenName = "Olivia",
                Surname = "Williams",
                Gender = Gender.Female,
                BirthDate = new DateTime(2007, 10, 17),
                BirthLocation = "Chicago",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("d97c6a2b-3e5f-4b91-9925-7f21d38a6b74"),
                GivenName = "Henry",
                Surname = "Williams",
                Gender = Gender.Male,
                BirthDate = new DateTime(2011, 12, 4),
                BirthLocation = "Chicago",
                DeathDate = new DateTime(2022, 7, 30),
                DeathLocation = "Chicago",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("e6a1c92d-5f3e-47d8-8123-6b7f21d3a5e4"),
                GivenName = "Liam",
                Surname = "Williams",
                Gender = Gender.Male,
                BirthDate = new DateTime(2014, 8, 9),
                BirthLocation = "Chicago",
                FamilyId = familyId,
            }
        );
    }

    private static void SeedBrownFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(BrownFamilyId);

        personBuilder.HasData(
            new Person
            {
                Id = Guid.Parse("b7a4c89f-62d5-4e31-bd8a-2f3c7d1b96e4"),
                GivenName = "George",
                Surname = "Brown",
                Gender = Gender.Male,
                BirthDate = new DateTime(1938, 11, 22),
                BirthLocation = "Houston",
                DeathDate = new DateTime(2005, 6, 15),
                DeathLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("c6f21d98-5b3e-471a-91d2-3f87c1b6d5e9"),
                GivenName = "Eleanor",
                Surname = "Brown",
                Gender = Gender.Female,
                BirthDate = new DateTime(1942, 4, 10),
                BirthLocation = "Houston",
                DeathDate = new DateTime(2012, 9, 8),
                DeathLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("d97b3e5a-6c41-4f92-8125-7d2a6f8c5e74"),
                GivenName = "Jonathan",
                Surname = "Brown",
                Gender = Gender.Male,
                BirthDate = new DateTime(1966, 7, 18),
                BirthLocation = "Houston",
                DeathDate = new DateTime(2020, 12, 21),
                DeathLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("e5a7b92d-6f3c-42d8-81a3-5b7d21c8f4e2"),
                GivenName = "Catherine",
                Surname = "Brown",
                Gender = Gender.Female,
                BirthDate = new DateTime(1969, 3, 29),
                BirthLocation = "Houston",
                DeathDate = new DateTime(2023, 5, 14),
                DeathLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("5ea9c874-0cf0-4bae-a7b1-7681036af33d"),
                GivenName = "Sophia",
                Surname = "Brown",
                Gender = Gender.Female,
                BirthDate = new DateTime(1995, 8, 15),
                BirthLocation = "Houston",
                DeathDate = new DateTime(2022, 10, 5),
                DeathLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("af711e40-aaa7-43f1-a60c-fce2afe6adba"),
                GivenName = "Noah",
                Surname = "Brown",
                Gender = Gender.Male,
                BirthDate = new DateTime(1998, 5, 7),
                BirthLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("b6e92a1d-5f3b-47d8-91c2-3f7d2a6b5e14"),
                GivenName = "Emma",
                Surname = "Brown",
                Gender = Gender.Female,
                BirthDate = new DateTime(2003, 1, 25),
                BirthLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("c97b2e5a-3f6d-4b91-9925-5a7d2a6f8c74"),
                GivenName = "Lucas",
                Surname = "Brown",
                Gender = Gender.Male,
                BirthDate = new DateTime(2007, 9, 14),
                BirthLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("d8a6b3e7-5c92-47d8-8123-6b2f7d1a5e34"),
                GivenName = "Madison",
                Surname = "Brown",
                Gender = Gender.Female,
                BirthDate = new DateTime(2012, 11, 3),
                BirthLocation = "Houston",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("e5b71d92-6f3c-42d8-81a3-7d2f6b3e5a24"),
                GivenName = "Henry",
                Surname = "Brown",
                Gender = Gender.Male,
                BirthDate = new DateTime(2016, 6, 20),
                BirthLocation = "Houston",
                FamilyId = familyId,
            }
        );
    }

    private static void SeedGonzalezFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(GonzalezFamilyId);

        personBuilder.HasData(
            new Person
            {
                Id = Guid.Parse("d5b72c3a-9f41-4e92-8125-6b7f2a1d8e34"),
                GivenName = "Carlos",
                Surname = "Gonzalez",
                Gender = Gender.Male,
                BirthDate = new DateTime(1950, 12, 5),
                BirthLocation = "Mexico City",
                DeathDate = new DateTime(2018, 3, 21),
                DeathLocation = "Mexico City",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("e6a1d92b-5f3c-47d8-91a2-3b7d2a6f8e24"),
                GivenName = "Isabella",
                Surname = "Gonzalez",
                Gender = Gender.Female,
                BirthDate = new DateTime(1955, 7, 19),
                BirthLocation = "Mexico City",
                DeathDate = new DateTime(2022, 8, 14),
                DeathLocation = "Mexico City",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("f87c2b6a-3f5d-4e92-9925-5a7d1a6b2e74"),
                GivenName = "Ricardo",
                Surname = "Gonzalez",
                Gender = Gender.Male,
                BirthDate = new DateTime(1982, 9, 11),
                BirthLocation = "Mexico City",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("a9d72b5a-6f3c-42d8-81a3-7b2f6d3e5a24"),
                GivenName = "Sofia",
                Surname = "Gonzalez",
                Gender = Gender.Female,
                BirthDate = new DateTime(1985, 6, 25),
                BirthLocation = "Mexico City",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("b6e92a1d-5f3b-47d8-81c2-3f7d2a6b5e14"),
                GivenName = "Mateo",
                Surname = "Gonzalez",
                Gender = Gender.Male,
                BirthDate = new DateTime(2015, 10, 8),
                BirthLocation = "Mexico City",
                FamilyId = familyId,
            }
        );
    }

    private static void SeedBagginsFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(BagginsFamilyId);

        personBuilder.HasData(
            new Person
            {
                Id = Guid.Parse("7b72b5f1-3010-4a68-8cc5-815b6cc4e4fb"),
                GivenName = "Bilbo",
                Surname = "Baggins",
                Gender = Gender.Male,
                BirthDate = new DateTime(1920, 9, 22),
                BirthLocation = "London",
                DeathDate = new DateTime(2001, 9, 22),
                DeathLocation = "London",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("8c708c1f-4e48-486b-933f-6b8aff07266f"),
                GivenName = "Belladonna",
                Surname = "Baggins",
                Gender = Gender.Female,
                BirthDate = new DateTime(1925, 2, 15),
                BirthLocation = "London",
                DeathDate = new DateTime(1994, 6, 18),
                DeathLocation = "London",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("6f8dcc83-05a0-433f-82f6-f4006a9abf19"),
                GivenName = "Frodo",
                Surname = "Baggins",
                Gender = Gender.Male,
                BirthDate = new DateTime(1968, 9, 22),
                BirthLocation = "London",
                DeathDate = new DateTime(2020, 10, 5),
                DeathLocation = "London",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("faa7efa2-75f6-4457-a397-209b047ccdee"),
                GivenName = "Drogo",
                Surname = "Baggins",
                Gender = Gender.Male,
                BirthDate = new DateTime(1950, 7, 20),
                BirthLocation = "London",
                DeathDate = new DateTime(1999, 3, 10),
                DeathLocation = "London",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("8bb30818-22c7-434b-a159-80c5040ee3c0"),
                GivenName = "Primula",
                Surname = "Baggins",
                Gender = Gender.Female,
                BirthDate = new DateTime(1952, 11, 5),
                BirthLocation = "London",
                DeathDate = new DateTime(1999, 3, 10),
                DeathLocation = "London",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("a9d41c72-6b5e-49f2-8123-7d3a6f8b2e64"),
                GivenName = "Samwise",
                Surname = "Baggins",
                Gender = Gender.Male,
                BirthDate = new DateTime(1975, 4, 6),
                BirthLocation = "London",
                FamilyId = familyId,
            }
        );
    }

    private static void SeedPotterFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(PotterFamilyId);

        personBuilder.HasData(
            new Person
            {
                Id = Guid.Parse("86dc9f24-2885-4d73-a02f-ce247805f3fc"),
                GivenName = "Henry",
                Surname = "Potter",
                Gender = Gender.Male,
                BirthDate = new DateTime(1880, 3, 15),
                BirthLocation = "London",
                DeathDate = new DateTime(1940, 11, 10),
                DeathLocation = "London",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("f23f864a-b937-4ab3-ac4c-a08c841cdcbf"),
                GivenName = "Charlus",
                Surname = "Potter",
                Gender = Gender.Male,
                BirthDate = new DateTime(1910, 5, 25),
                BirthLocation = "London",
                DeathDate = new DateTime(1970, 2, 14),
                DeathLocation = "London",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("e5a72c9b-6f3d-47d2-8325-4f91b72d3e86"),
                GivenName = "Dorea",
                Surname = "Black Potter",
                Gender = Gender.Female,
                BirthDate = new DateTime(1912, 9, 12),
                BirthLocation = "London",
                DeathDate = new DateTime(1977, 7, 4),
                DeathLocation = "London",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("f8b72c3d-91d5-4e42-8326-5f2a6b7d3e14"),
                GivenName = "James",
                Surname = "Potter",
                Gender = Gender.Male,
                BirthDate = new DateTime(1960, 3, 27),
                BirthLocation = "London",
                DeathDate = new DateTime(1981, 10, 31),
                DeathLocation = "Godric's Hollow",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("023ff397-e06c-42a9-8170-b872c834315b"),
                GivenName = "Lily",
                Surname = "Evans Potter",
                Gender = Gender.Female,
                BirthDate = new DateTime(1960, 1, 30),
                BirthLocation = "Cokeworth",
                DeathDate = new DateTime(1981, 10, 31),
                DeathLocation = "Godric's Hollow",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("e3badc5d-a88f-4b6b-aaed-1cc764c0a2b8"),
                GivenName = "Harry",
                Surname = "Potter",
                Gender = Gender.Male,
                BirthDate = new DateTime(1980, 7, 31),
                BirthLocation = "Godric's Hollow",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("c6a1d92b-5f3c-42d8-81a2-3b7d2a6f8e26"),
                GivenName = "Ginny",
                Surname = "Weasley Potter",
                Gender = Gender.Female,
                BirthDate = new DateTime(1981, 8, 11),
                BirthLocation = "Ottery St Catchpole",
                FamilyId = familyId,
            }
        );
    }

    private static void SeedAtreidesFamilyMembers(EntityTypeBuilder<Person> personBuilder)
    {
        var familyId = Guid.Parse(AtreidesFamilyId);

        personBuilder.HasData(
            new Person
            {
                Id = Guid.Parse("b7c92a5d-3f6e-41d8-99a5-5f7d2a6b3e24"),
                GivenName = "Victor",
                Surname = "Atreides",
                Gender = Gender.Male,
                BirthDate = new DateTime(1875, 6, 10),
                BirthLocation = "Athens",
                DeathDate = new DateTime(1945, 5, 8),
                DeathLocation = "Athens",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("c6a1d92b-5f3c-42d8-81a2-3b7d2a6f8e24"),
                GivenName = "Helena",
                Surname = "Atreides",
                Gender = Gender.Female,
                BirthDate = new DateTime(1880, 4, 15),
                BirthLocation = "Athens",
                DeathDate = new DateTime(1950, 9, 30),
                DeathLocation = "Athens",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("d8b72c3a-9f41-4e92-8125-6b7f2a1d8e34"),
                GivenName = "Leto",
                Surname = "Atreides",
                Gender = Gender.Male,
                BirthDate = new DateTime(1935, 10, 12),
                BirthLocation = "Athens",
                DeathDate = new DateTime(1980, 6, 21),
                DeathLocation = "Lisbon",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("d9168577-b6ed-4e3a-9bae-8d805be65d18"),
                GivenName = "Jessica",
                Surname = "Atreides",
                Gender = Gender.Female,
                BirthDate = new DateTime(1940, 5, 3),
                BirthLocation = "Lisbon",
                DeathDate = new DateTime(2010, 8, 14),
                DeathLocation = "Lisbon",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("26218dc0-0a44-4b8b-8361-332b3b1c22e9"),
                GivenName = "Paul",
                Surname = "Atreides",
                Gender = Gender.Male,
                BirthDate = new DateTime(1965, 9, 22),
                BirthLocation = "Lisbon",
                FamilyId = familyId,
            },
            new Person
            {
                Id = Guid.Parse("10c9e73f-8bf1-47cf-8e4a-62781780c519"),
                GivenName = "Alia",
                Surname = "Atreides",
                Gender = Gender.Female,
                BirthDate = new DateTime(1970, 12, 7),
                BirthLocation = "Lisbon",
                FamilyId = familyId,
            }
        );
    }
}
