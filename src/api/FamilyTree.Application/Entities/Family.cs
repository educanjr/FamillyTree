namespace FamilyTree.Application.Entities;

public class Family
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Person> Members { get; set; } = new();
}
