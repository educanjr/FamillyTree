namespace FamilyTree.Application.Dtos;

public record FamilyDto(
    Guid Id,
    string Name,
    List<PersonDto> Members);
