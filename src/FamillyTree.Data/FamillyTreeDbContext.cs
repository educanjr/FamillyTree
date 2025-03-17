using FamillyTree.Application.Entities;
using FamillyTree.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FamillyTree.Data;

public class FamillyTreeDbContext : DbContext, IFamillyTreeDbContext
{
    private readonly IDbSettings _dbSettings;
    public FamillyTreeDbContext(IDbSettings dbSettings) : base() =>
        _dbSettings = dbSettings;

    public FamillyTreeDbContext(DbContextOptions<FamillyTreeDbContext> options, IDbSettings dbSettings) : base(options) =>
        _dbSettings = dbSettings;

    public DbSet<Person> Persons { get; set; }
    public DbSet<Familly> Famillies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonConfiguration());
        modelBuilder.ApplyConfiguration(new FamillyTreeConfiguration());
    }
}
