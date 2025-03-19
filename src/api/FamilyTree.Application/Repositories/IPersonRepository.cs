using FamilyTree.Application.Entities;

namespace FamilyTree.Application.Repositories;

public interface IPersonRepository
{
    ValueTask<Person?> GetFamilyMember(Guid familyId, Guid memberId);
}
