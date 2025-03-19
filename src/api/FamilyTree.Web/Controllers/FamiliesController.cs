using FamilyTree.Application.CommandAndQueries.Family.GetAll;
using FamilyTree.Application.CommandAndQueries.Family.GetById;
using FamilyTree.Application.CommandAndQueries.Person.GetFamilyMember;
using FamilyTree.Application.Common;
using FamilyTree.Web.Abstractions;
using FamilyTree.Web.Common;
using FamilyTree.Web.Extensions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace FamilyTree.Controllers;

[Asp.Versioning.ApiVersion("1")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]

public class FamiliesController : BaseApiController<FamiliesController>
{
    public FamiliesController(ISender sender, ILogger<FamiliesController> logger)
        :base(sender, logger)
    {
    }

    [HttpGet]
    [EndpointName(nameof(GetFamilies))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetFamilies()
    {
        try
        {
            return await ResultObject
               .Create(new GetAllFamiliesQuery())
               .Bind(cmd => Sender.Send(cmd))
               .Match(
                   families => Ok(DataConverters.FamilyListConverter(families)),
                   HandleFailure);
        }
        catch (Exception ex)
        {
            return HandleError(ex);
        }
    }

    [HttpGet("{id}")]
    [EndpointName(nameof(GetFamily))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetFamily(Guid id)
    {
        try
        {
            return await ResultObject
               .Create(new GetFamilyByIdQuery(id))
               .Bind(cmd => Sender.Send(cmd))
               .Match(
                   family => Ok(DataConverters.FamilyConverter(family)),
                   HandleFailure);
        }
        catch (Exception ex)
        {
            return HandleError(ex);
        }
    }

    [HttpGet("{familyId}/members/{memberId}")]
    [EndpointName(nameof(GetFamilyMember))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetFamilyMember(Guid familyId, Guid memberId)
    {
        try
        {
            return await ResultObject
               .Create(new GetFamilyMemberQuery(familyId, memberId))
               .Bind(cmd => Sender.Send(cmd))
               .Match(
                   member => Ok(DataConverters.PersonConverter(member)),
                   HandleFailure);
        }
        catch (Exception ex)
        {
            return HandleError(ex);
        }
    }
}
