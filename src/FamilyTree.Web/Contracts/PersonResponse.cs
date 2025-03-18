using FamilyTree.Application.Enums;

namespace FamilyTree.Web.Contracts;

public record PersonResponse(
    Guid Id,
    string GivenName,
    string Surname,
    string Gender,
    string Lifespan);
