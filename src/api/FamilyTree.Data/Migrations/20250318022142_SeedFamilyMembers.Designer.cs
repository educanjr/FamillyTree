﻿// <auto-generated />
using System;
using FamilyTree.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FamilyTree.Data.Migrations
{
    [DbContext(typeof(FamilyTreeDbContext))]
    [Migration("20250318022142_SeedFamilyMembers")]
    partial class SeedFamilyMembers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FamilyTree.Application.Entities.Family", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Famillies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"),
                            Name = "Smith Family Tree"
                        });
                });

            modelBuilder.Entity("FamilyTree.Application.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("BirthLocation")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeathLocation")
                        .HasColumnType("text");

                    b.Property<Guid>("FamilyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2a5bcfe-da88-46e7-8439-d8f5ec85c474"),
                            BirthDate = new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthLocation = "New York",
                            DeathLocation = "",
                            FamilyId = new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"),
                            Gender = "Male",
                            GivenName = "John",
                            Surname = "Smith"
                        },
                        new
                        {
                            Id = new Guid("30e99d4d-4700-4c22-a1a3-ebdec1eb79b0"),
                            BirthLocation = "",
                            DeathDate = new DateTime(2015, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathLocation = "Los Angeles",
                            FamilyId = new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"),
                            Gender = "Female",
                            GivenName = "Jane",
                            Surname = "Smith"
                        },
                        new
                        {
                            Id = new Guid("69d3685a-3b75-4c32-86a0-1dfbb585c10a"),
                            BirthDate = new DateTime(1910, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthLocation = "Chicago",
                            DeathLocation = "",
                            FamilyId = new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"),
                            Gender = "Male",
                            GivenName = "Robert",
                            Surname = "Brown"
                        },
                        new
                        {
                            Id = new Guid("5eeceddf-f9a2-4b7e-b236-2dba0000cdbf"),
                            BirthDate = new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BirthLocation = "Seattle",
                            DeathLocation = "",
                            FamilyId = new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"),
                            Gender = "Female",
                            GivenName = "Emma",
                            Surname = "Johnson"
                        });
                });

            modelBuilder.Entity("FamilyTree.Application.Entities.Person", b =>
                {
                    b.HasOne("FamilyTree.Application.Entities.Family", null)
                        .WithMany("Members")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FamilyTree.Application.Entities.Family", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
