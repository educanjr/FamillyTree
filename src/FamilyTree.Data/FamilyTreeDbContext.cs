using FamilyTree.Application.Entities;
using FamilyTree.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Data;

public class FamilyTreeDbContext : DbContext, IFamilyTreeDbContext
{
    private readonly IDbSettings _dbSettings;
    public FamilyTreeDbContext(IDbSettings dbSettings) : base() =>
        _dbSettings = dbSettings;

    public FamilyTreeDbContext(DbContextOptions<FamilyTreeDbContext> options, IDbSettings dbSettings) : base(options) =>
        _dbSettings = dbSettings;

    public DbSet<Person> Persons { get; set; }
    public DbSet<Family> Famillies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonConfiguration());
        modelBuilder.ApplyConfiguration(new FamilyTreeConfiguration());
    }
}
