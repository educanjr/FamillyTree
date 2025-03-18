namespace FamilyTree.Data.Abstractions;

public abstract class BaseRepository
{
    private readonly IFamilyTreeDbContext _context;

    protected IFamilyTreeDbContext FamilyTreeDbContext => _context;

    public BaseRepository(IFamilyTreeDbContext context) =>
        _context = context;
}
