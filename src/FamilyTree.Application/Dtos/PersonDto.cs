using FamilyTree.Application.Enums;

namespace FamilyTree.Application.Dtos;

public record PersonDto(
    Guid Id,
    string GivenName,
    string Surname,
    Gender Gender,
    string Lifespan);
