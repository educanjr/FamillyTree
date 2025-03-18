﻿// <auto-generated />
using System;
using FamilyTree.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FamilyTree.Data.Migrations
{
    [DbContext(typeof(FamilyTreeDbContext))]
    partial class FamilyTreeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
