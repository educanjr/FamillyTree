using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FamilyTree.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMembersForFamilies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "BirthLocation", "DeathDate", "DeathLocation", "FamilyId", "Gender", "GivenName", "Surname" },
                values: new object[,]
                {
                    { new Guid("023ff397-e06c-42a9-8170-b872c834315b"), new DateTime(1960, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Cokeworth", new DateTime(1981, 10, 31, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Godric's Hollow", new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"), "Female", "Lily", "Evans Potter" },
                    { new Guid("10c9e73f-8bf1-47cf-8e4a-62781780c519"), new DateTime(1970, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Lisbon", null, null, new Guid("c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Female", "Alia", "Atreides" },
                    { new Guid("26218dc0-0a44-4b8b-8361-332b3b1c22e9"), new DateTime(1965, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Lisbon", null, null, new Guid("c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Male", "Paul", "Atreides" },
                    { new Guid("27c74ac5-ec57-4bc8-8fa9-6c1d82767f6d"), new DateTime(2005, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Los Angeles", null, null, new Guid("a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43"), "Female", "Sophia", "Johnson" },
                    { new Guid("5e345c48-8a73-40cd-bff8-b92c8d3758c5"), new DateTime(1977, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Los Angeles", new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Los Angeles", new Guid("a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43"), "Female", "Linda", "Johnson" },
                    { new Guid("5ea9c874-0cf0-4bae-a7b1-7681036af33d"), new DateTime(1995, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Female", "Sophia", "Brown" },
                    { new Guid("6f8dcc83-05a0-433f-82f6-f4006a9abf19"), new DateTime(1968, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new Guid("a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64"), "Male", "Frodo", "Baggins" },
                    { new Guid("7b72b5f1-3010-4a68-8cc5-815b6cc4e4fb"), new DateTime(1920, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(2001, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new Guid("a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64"), "Male", "Bilbo", "Baggins" },
                    { new Guid("86dc9f24-2885-4d73-a02f-ce247805f3fc"), new DateTime(1880, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(1940, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"), "Male", "Henry", "Potter" },
                    { new Guid("8a97b09d-23c4-4fc8-8c02-d75284b2cf63"), new DateTime(2008, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Los Angeles", null, null, new Guid("a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43"), "Male", "Ethan", "Johnson" },
                    { new Guid("8bb30818-22c7-434b-a159-80c5040ee3c0"), new DateTime(1952, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(1999, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new Guid("a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64"), "Female", "Primula", "Baggins" },
                    { new Guid("8c708c1f-4e48-486b-933f-6b8aff07266f"), new DateTime(1925, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(1994, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new Guid("a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64"), "Female", "Belladonna", "Baggins" },
                    { new Guid("9a969a1e-a161-4727-9f4d-bc7a68fd6b87"), new DateTime(1999, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Female", "Sophia", "Williams" },
                    { new Guid("a72b9f31-5c44-4f02-bd9a-3e7f2a6d1e59"), new DateTime(1940, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new DateTime(2010, 3, 24, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Male", "Richard", "Williams" },
                    { new Guid("a9b63c14-9273-4cc5-ae35-ff8e8f43b8c2"), new DateTime(2005, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Male", "Lucas", "Smith" },
                    { new Guid("a9d41c72-6b5e-49f2-8123-7d3a6f8b2e64"), new DateTime(1975, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", null, null, new Guid("a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64"), "Male", "Samwise", "Baggins" },
                    { new Guid("a9d72b5a-6f3c-42d8-81a3-7b2f6d3e5a24"), new DateTime(1985, 6, 25, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Mexico City", null, null, new Guid("c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Female", "Sofia", "Gonzalez" },
                    { new Guid("af711e40-aaa7-43f1-a60c-fce2afe6adba"), new DateTime(1998, 5, 7, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", null, null, new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Male", "Noah", "Brown" },
                    { new Guid("b4c98e39-71d6-42d8-b185-3e3d21b5e5f2"), new DateTime(2009, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Female", "Grace", "Smith" },
                    { new Guid("b6e92a1d-5f3b-47d8-81c2-3f7d2a6b5e14"), new DateTime(2015, 10, 8, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Mexico City", null, null, new Guid("c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Male", "Mateo", "Gonzalez" },
                    { new Guid("b6e92a1d-5f3b-47d8-91c2-3f7d2a6b5e14"), new DateTime(2003, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", null, null, new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Female", "Emma", "Brown" },
                    { new Guid("b7a4c89f-62d5-4e31-bd8a-2f3c7d1b96e4"), new DateTime(1938, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new DateTime(2005, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Male", "George", "Brown" },
                    { new Guid("b7a63c14-9273-4cc5-ae35-ff8e8f43b8c2"), new DateTime(1875, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Los Angeles", null, null, new Guid("a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43"), "Male", "Robert", "Johnson" },
                    { new Guid("b7c92a5d-3f6e-41d8-99a5-5f7d2a6b3e24"), new DateTime(1875, 6, 10, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Athens", new DateTime(1945, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Athens", new Guid("c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Male", "Victor", "Atreides" },
                    { new Guid("b9d4e72a-5c6f-48f1-9123-7d38f21b5e74"), new DateTime(2002, 6, 8, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", null, null, new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Male", "Daniel", "Williams" },
                    { new Guid("be42f68b-57f2-4721-8dc5-6d0c2fb2c8de"), new DateTime(2011, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Los Angeles", null, null, new Guid("a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43"), "Male", "Oliver", "Johnson" },
                    { new Guid("c4a76f38-5f77-499e-a1f1-65726b2e3f3d"), new DateTime(1945, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Male", "Michael", "Smith" },
                    { new Guid("c6a1d92b-5f3c-42d8-81a2-3b7d2a6f8e24"), new DateTime(1880, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Athens", new DateTime(1950, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Athens", new Guid("c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Female", "Helena", "Atreides" },
                    { new Guid("c6a1d92b-5f3c-42d8-81a2-3b7d2a6f8e26"), new DateTime(1981, 8, 11, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Ottery St Catchpole", null, null, new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"), "Female", "Ginny", "Weasley Potter" },
                    { new Guid("c6f21d98-5b3e-471a-91d2-3f87c1b6d5e9"), new DateTime(1942, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new DateTime(2012, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Female", "Eleanor", "Brown" },
                    { new Guid("c6f87b24-51b7-4e72-91c2-4f3d38f66d22"), new DateTime(2012, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", null, null, new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Male", "Ethan", "Smith" },
                    { new Guid("c81b72d4-6e93-41f2-81d5-3f2a6c87b5e2"), new DateTime(2007, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", null, null, new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Female", "Olivia", "Williams" },
                    { new Guid("c97b2e5a-3f6d-4b91-9925-5a7d2a6f8c74"), new DateTime(2007, 9, 14, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", null, null, new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Male", "Lucas", "Brown" },
                    { new Guid("c9b6d4a1-52f3-4e92-b1c7-7e5f21d38a6b"), new DateTime(1971, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Female", "Linda", "Williams" },
                    { new Guid("d3b57f28-3a88-4e02-bb36-2283f2b4d4a9"), new DateTime(1948, 10, 3, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Female", "Sarah", "Smith" },
                    { new Guid("d4c79b12-8f25-4e91-9726-5f2d71a3b64e"), new DateTime(1944, 7, 9, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new DateTime(2015, 6, 2, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Female", "Margaret", "Williams" },
                    { new Guid("d5b72c3a-9f41-4e92-8125-6b7f2a1d8e34"), new DateTime(1950, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Mexico City", new DateTime(2018, 3, 21, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Mexico City", new Guid("c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Male", "Carlos", "Gonzalez" },
                    { new Guid("d8a6b3e7-5c92-47d8-8123-6b2f7d1a5e34"), new DateTime(2012, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", null, null, new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Female", "Madison", "Brown" },
                    { new Guid("d8b72c3a-9f41-4e92-8125-6b7f2a1d8e34"), new DateTime(1935, 10, 12, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Athens", new DateTime(1980, 6, 21, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Lisbon", new Guid("c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Male", "Leto", "Atreides" },
                    { new Guid("d9168577-b6ed-4e3a-9bae-8d805be65d18"), new DateTime(1940, 5, 3, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Lisbon", new DateTime(2010, 8, 14, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Lisbon", new Guid("c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Female", "Jessica", "Atreides" },
                    { new Guid("d972cfc3-71c7-4fd2-9925-5b6e2d42f777"), new DateTime(2016, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", null, null, new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Female", "Madison", "Smith" },
                    { new Guid("d97b3e5a-6c41-4f92-8125-7d2a6f8c5e74"), new DateTime(1966, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new DateTime(2020, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Male", "Jonathan", "Brown" },
                    { new Guid("d97c6a2b-3e5f-4b91-9925-7f21d38a6b74"), new DateTime(2011, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Male", "Henry", "Williams" },
                    { new Guid("e3badc5d-a88f-4b6b-aaed-1cc764c0a2b8"), new DateTime(1980, 7, 31, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Godric's Hollow", null, null, new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"), "Male", "Harry", "Potter" },
                    { new Guid("e5a72c9b-6f3d-47d2-8325-4f91b72d3e86"), new DateTime(1912, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(1977, 7, 4, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"), "Female", "Dorea", "Black Potter" },
                    { new Guid("e5a7b92d-6f3c-42d8-81a3-5b7d21c8f4e2"), new DateTime(1969, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Female", "Catherine", "Brown" },
                    { new Guid("e5b71d92-6f3c-42d8-81a3-7d2f6b3e5a24"), new DateTime(2016, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Houston", null, null, new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Male", "Henry", "Brown" },
                    { new Guid("e5d79a14-92a7-4f92-81b2-6f3d38f66d99"), new DateTime(1970, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Female", "Emily", "Smith" },
                    { new Guid("e6a1c92d-5f3e-47d8-8123-6b7f21d3a5e4"), new DateTime(2014, 8, 9, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", null, null, new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Male", "Liam", "Williams" },
                    { new Guid("e6a1d92b-5f3c-47d8-91a2-3b7d2a6f8e24"), new DateTime(1955, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Mexico City", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Mexico City", new Guid("c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Female", "Isabella", "Gonzalez" },
                    { new Guid("f23f864a-b937-4ab3-ac4c-a08c841cdcbf"), new DateTime(1910, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(1970, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"), "Male", "Charlus", "Potter" },
                    { new Guid("f81a72c4-9e38-41b5-95d2-3c6d87f2b3e1"), new DateTime(1968, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Chicago", new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Male", "David", "Williams" },
                    { new Guid("f872bfc3-99b7-4fd2-8715-3b6e2d42f887"), new DateTime(1972, 6, 8, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new DateTime(2015, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "New York", new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Male", "Jack", "Smith" },
                    { new Guid("f87c2b6a-3f5d-4e92-9925-5a7d1a6b2e74"), new DateTime(1982, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Mexico City", null, null, new Guid("c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Male", "Ricardo", "Gonzalez" },
                    { new Guid("f8b72c3d-91d5-4e42-8326-5f2a6b7d3e14"), new DateTime(1960, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(1981, 10, 31, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "Godric's Hollow", new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"), "Male", "James", "Potter" },
                    { new Guid("faa7efa2-75f6-4457-a397-209b047ccdee"), new DateTime(1950, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new DateTime(1999, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc).ToUniversalTime(), "London", new Guid("a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64"), "Male", "Drogo", "Baggins" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("023ff397-e06c-42a9-8170-b872c834315b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("10c9e73f-8bf1-47cf-8e4a-62781780c519"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("26218dc0-0a44-4b8b-8361-332b3b1c22e9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("27c74ac5-ec57-4bc8-8fa9-6c1d82767f6d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5e345c48-8a73-40cd-bff8-b92c8d3758c5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5ea9c874-0cf0-4bae-a7b1-7681036af33d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6f8dcc83-05a0-433f-82f6-f4006a9abf19"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("7b72b5f1-3010-4a68-8cc5-815b6cc4e4fb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("86dc9f24-2885-4d73-a02f-ce247805f3fc"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8a97b09d-23c4-4fc8-8c02-d75284b2cf63"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8bb30818-22c7-434b-a159-80c5040ee3c0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8c708c1f-4e48-486b-933f-6b8aff07266f"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9a969a1e-a161-4727-9f4d-bc7a68fd6b87"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a72b9f31-5c44-4f02-bd9a-3e7f2a6d1e59"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a9b63c14-9273-4cc5-ae35-ff8e8f43b8c2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a9d41c72-6b5e-49f2-8123-7d3a6f8b2e64"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a9d72b5a-6f3c-42d8-81a3-7b2f6d3e5a24"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("af711e40-aaa7-43f1-a60c-fce2afe6adba"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b4c98e39-71d6-42d8-b185-3e3d21b5e5f2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b6e92a1d-5f3b-47d8-81c2-3f7d2a6b5e14"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b6e92a1d-5f3b-47d8-91c2-3f7d2a6b5e14"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b7a4c89f-62d5-4e31-bd8a-2f3c7d1b96e4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b7a63c14-9273-4cc5-ae35-ff8e8f43b8c2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b7c92a5d-3f6e-41d8-99a5-5f7d2a6b3e24"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("b9d4e72a-5c6f-48f1-9123-7d38f21b5e74"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("be42f68b-57f2-4721-8dc5-6d0c2fb2c8de"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c4a76f38-5f77-499e-a1f1-65726b2e3f3d"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c6a1d92b-5f3c-42d8-81a2-3b7d2a6f8e24"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c6a1d92b-5f3c-42d8-81a2-3b7d2a6f8e26"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c6f21d98-5b3e-471a-91d2-3f87c1b6d5e9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c6f87b24-51b7-4e72-91c2-4f3d38f66d22"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c81b72d4-6e93-41f2-81d5-3f2a6c87b5e2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c97b2e5a-3f6d-4b91-9925-5a7d2a6f8c74"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c9b6d4a1-52f3-4e92-b1c7-7e5f21d38a6b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d3b57f28-3a88-4e02-bb36-2283f2b4d4a9"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d4c79b12-8f25-4e91-9726-5f2d71a3b64e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d5b72c3a-9f41-4e92-8125-6b7f2a1d8e34"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d8a6b3e7-5c92-47d8-8123-6b2f7d1a5e34"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d8b72c3a-9f41-4e92-8125-6b7f2a1d8e34"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d9168577-b6ed-4e3a-9bae-8d805be65d18"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d972cfc3-71c7-4fd2-9925-5b6e2d42f777"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d97b3e5a-6c41-4f92-8125-7d2a6f8c5e74"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d97c6a2b-3e5f-4b91-9925-7f21d38a6b74"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e3badc5d-a88f-4b6b-aaed-1cc764c0a2b8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e5a72c9b-6f3d-47d2-8325-4f91b72d3e86"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e5a7b92d-6f3c-42d8-81a3-5b7d21c8f4e2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e5b71d92-6f3c-42d8-81a3-7d2f6b3e5a24"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e5d79a14-92a7-4f92-81b2-6f3d38f66d99"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e6a1c92d-5f3e-47d8-8123-6b7f21d3a5e4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e6a1d92b-5f3c-47d8-91a2-3b7d2a6f8e24"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f23f864a-b937-4ab3-ac4c-a08c841cdcbf"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f81a72c4-9e38-41b5-95d2-3c6d87f2b3e1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f872bfc3-99b7-4fd2-8715-3b6e2d42f887"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f87c2b6a-3f5d-4e92-9925-5a7d1a6b2e74"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f8b72c3d-91d5-4e42-8326-5f2a6b7d3e14"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("faa7efa2-75f6-4457-a397-209b047ccdee"));
        }
    }
}
