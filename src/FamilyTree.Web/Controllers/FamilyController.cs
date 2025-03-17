using FamilyTree.Web.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace FamilyTree.Controllers;

[Asp.Versioning.ApiVersion("1")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]

public class FamilyController : BaseApiController<FamilyController>
{
    public FamilyController(ISender sender, ILogger<FamilyController> logger)
        :base(sender, logger)
    {
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
            await NotImplementedEndpointPlaceholder();
            return Ok();
        }
        catch (Exception ex)
        {
            return HandleError(ex);
        }
    }
}
