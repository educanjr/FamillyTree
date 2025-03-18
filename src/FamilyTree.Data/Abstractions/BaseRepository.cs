namespace FamilyTree.Data.Abstractions;

public abstract class BaseRepository(IFamilyTreeDbContext context)
{
    protected IFamilyTreeDbContext FamilyTreeDbContext => context;
}
