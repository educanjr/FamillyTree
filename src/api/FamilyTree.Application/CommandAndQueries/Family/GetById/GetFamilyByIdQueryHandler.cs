using FamilyTree.Application.Abstractions;
using FamilyTree.Application.Common;
using FamilyTree.Application.Dtos;
using FamilyTree.Application.Exceptions;
using FamilyTree.Application.Repositories;

namespace FamilyTree.Application.CommandAndQueries.Family.GetById;

internal sealed class GetFamilyByIdQueryHandler(IFamilyRepository familyRepository) 
    : IQueryHandler<GetFamilyByIdQuery, FamilyDto>
{
    public async Task<ResultObject<FamilyDto>> Handle(GetFamilyByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var family = await familyRepository.GetFamily(request.Id) ??
                throw new DataNotFoundException(nameof(Family), request.Id.ToString());

            return new FamilyDto(
                Id: family.Id,
                Name: family.Name,
                Members: family.Members?.Select(DataConverters.PersonConverter).ToList() ?? []);

        }
        catch (Exception ex)
        {
            return ResultObject.NotFound<FamilyDto>(ex.Message);
        }
    }
}
