using FamilyTree.Application.Dtos;

namespace FamilyTree.Web.Contracts;

public sealed record FamilyResponse(
    Guid Id,
    string Name,
    List<PersonResponse> Members);
