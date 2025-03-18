using FamilyTree.Application.Entities;

namespace FamilyTree.Application.Repositories;

public interface IFamilyRepository
{
    ValueTask<Family?> GetFamily(Guid familyId);
}
