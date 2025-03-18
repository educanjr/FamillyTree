using FamilyTree.Application.Abstractions;
using FamilyTree.Application.Common;
using FamilyTree.Application.Dtos;
using FamilyTree.Application.Repositories;

namespace FamilyTree.Application.CommandAndQueries.Family.GetAll;

internal sealed class GetAllFamiliesQueryHandler(IFamilyRepository familyRepository) 
    : IQueryHandler<GetAllFamiliesQuery, IList<FamilyDto>>
{
    public async Task<ResultObject<IList<FamilyDto>>> Handle(GetAllFamiliesQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var families = await familyRepository.GetFamilies() ?? [];

            return families
                .Select(x => new FamilyDto(
                    Id: x.Id,
                    Name: x.Name,
                    Members: x.Members?.Select(DataConverters.PersonConverter).ToList() ?? []))
                .ToList();

        }
        catch (Exception ex)
        {
            return ResultObject.NotFound<IList<FamilyDto>>(ex.Message);
        }
    }
}
