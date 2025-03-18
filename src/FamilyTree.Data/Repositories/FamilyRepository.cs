using FamilyTree.Application.Entities;
using FamilyTree.Application.Repositories;
using FamilyTree.Data.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Data.Repositories;

public sealed class FamilyRepository : BaseRepository, IFamilyRepository
{
    public FamilyRepository(IFamilyTreeDbContext context) : base(context)
    {
    }

    public async ValueTask<Family?> GetFamily(Guid familyId) =>
        await FamilyTreeDbContext.Famillies
            .AsNoTracking()
            .Where(x => x.Id == familyId)
            .Include(x => x.Members)
            .FirstOrDefaultAsync();
}
