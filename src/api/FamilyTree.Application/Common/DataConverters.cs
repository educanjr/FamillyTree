using FamilyTree.Application.Dtos;
using FamilyTree.Application.Entities;

namespace FamilyTree.Application.Common;

internal static class DataConverters
{
    public static PersonDto PersonConverter(Person person) =>
        new(
            Id: person.Id,
            GivenName: person.GivenName,
            Surname: person.Surname,
            Gender: person.Gender,
            Lifespan: person.GetLifespan());
}
