using FamilyTree.Application.Entities;
using FamilyTree.Application.Repositories;
using FamilyTree.Data.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Data.Repositories;

public class PersonRepository(IFamilyTreeDbContext context)
    : BaseRepository(context), IPersonRepository
{
    public async ValueTask<Person?> GetFamilyMember(Guid familyId, Guid memberId) =>
        await FamilyTreeDbContext.Persons
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == memberId && x.FamilyId == familyId);
}
