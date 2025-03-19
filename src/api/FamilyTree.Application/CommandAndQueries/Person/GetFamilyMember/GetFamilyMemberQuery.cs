using FamilyTree.Application.Abstractions;
using FamilyTree.Application.Dtos;

namespace FamilyTree.Application.CommandAndQueries.Person.GetFamilyMember;

public sealed record GetFamilyMemberQuery(Guid FamilyId, Guid MemberId) : IQuery<PersonDto>;
