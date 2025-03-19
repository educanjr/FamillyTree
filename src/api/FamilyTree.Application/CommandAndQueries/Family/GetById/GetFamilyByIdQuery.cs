using FamilyTree.Application.Abstractions;
using FamilyTree.Application.Dtos;

namespace FamilyTree.Application.CommandAndQueries.Family.GetById;

public sealed record GetFamilyByIdQuery(Guid Id) : IQuery<FamilyDto>;
