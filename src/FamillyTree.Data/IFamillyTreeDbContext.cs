using FamillyTree.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace FamillyTree.Data;

public interface IFamillyTreeDbContext : IDisposable
{
    DbSet<Person> Persons { get; set; }
    DbSet<Familly> Famillies { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
