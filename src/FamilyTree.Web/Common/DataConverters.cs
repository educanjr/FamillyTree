using FamilyTree.Application.Dtos;
using FamilyTree.Web.Contracts;

namespace FamilyTree.Web.Common;

internal static class DataConverters
{
    public static FamilyResponse FamilyConverter(FamilyDto applicationData) =>
        new(
            Id: applicationData.Id,
            Name: applicationData.Name,
            Members: applicationData.Members.Select(PersonConverter).ToList());

    public static PersonResponse PersonConverter(PersonDto applicationData) =>
        new(
            Id: applicationData.Id,
            Surname: applicationData.Surname,
            GivenName: applicationData.GivenName,
            Lifespan: applicationData.Lifespan,
            Gender: applicationData.Gender.ToString());
}
