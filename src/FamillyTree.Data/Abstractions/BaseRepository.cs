namespace FamillyTree.Data.Abstractions;

public abstract class BaseRepository
{
    private readonly IFamillyTreeDbContext _context;

    protected IFamillyTreeDbContext ConwayDbContext => _context;

    public BaseRepository(IFamillyTreeDbContext context) =>
        _context = context;
}
