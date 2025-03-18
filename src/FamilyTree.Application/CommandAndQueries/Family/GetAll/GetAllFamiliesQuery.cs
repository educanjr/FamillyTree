using FamilyTree.Application.Abstractions;
using FamilyTree.Application.Dtos;

namespace FamilyTree.Application.CommandAndQueries.Family.GetAll;

public sealed record GetAllFamiliesQuery() : IQuery<IList<FamilyDto>>;
