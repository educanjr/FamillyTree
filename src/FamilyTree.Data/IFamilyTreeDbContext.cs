using FamilyTree.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Data;

public interface IFamilyTreeDbContext : IDisposable
{
    DbSet<Person> Persons { get; set; }
    DbSet<Family> Famillies { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
