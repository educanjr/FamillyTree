using FamilyTree.Application.Abstractions;
using FamilyTree.Application.Common;
using FamilyTree.Application.Dtos;
using FamilyTree.Application.Exceptions;
using FamilyTree.Application.Repositories;

namespace FamilyTree.Application.CommandAndQueries.Person.GetFamilyMember;

internal sealed class GetFamilyMemberQueryHandler(IPersonRepository personRepository)
    : IQueryHandler<GetFamilyMemberQuery, PersonDto>
{
    public async Task<ResultObject<PersonDto>> Handle(GetFamilyMemberQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var person = await personRepository.GetFamilyMember(request.FamilyId, request.MemberId) ??
                throw new DataNotFoundException(nameof(PersonDto), request.MemberId.ToString());

            return DataConverters.PersonConverter(person);

        }
        catch (Exception ex)
        {
            return ResultObject.NotFound<PersonDto>(ex.Message);
        }
    }
}
