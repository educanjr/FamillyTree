using FamilyTree.Application.Enums;

namespace FamilyTree.Application.Entities;

public class Person
{
    public Guid Id { get; set; }
    public string GivenName { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? BirthLocation { get; set; }
    public DateTime? DeathDate { get; set; }
    public string? DeathLocation { get; set; }
    public Guid FamilyId { get; set; }

    public string GetLifespan()
    {
        const string livingSpan = "(Living)";

        if (DeathDate.HasValue && BirthDate.HasValue)
        {
            return $"({BirthDate.Value.Year}-{DeathDate.Value.Year})";
        }

        if (DeathDate.HasValue)
        {
            return $"(-{DeathDate.Value.Year})";
        }

        if (!BirthDate.HasValue && !DeathDate.HasValue)
        {
            return livingSpan;
        }

        if (BirthDate.HasValue)
        {
            int age = DateTime.Now.Year - BirthDate.Value.Year;
            return age < 120 ? livingSpan : $"({BirthDate.Value.Year}-)";
        }

        return livingSpan;
    }
}
