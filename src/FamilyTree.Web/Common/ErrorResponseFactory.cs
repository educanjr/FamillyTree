using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FamilyTree.Web.Common;

public static class ErrorResponseFactory
{
    public static (HttpStatusCode, ProblemDetails) BuildErrorResponse(Exception exception)
    {
        var statusCode = exception switch
        {
            InvalidOperationException => HttpStatusCode.BadRequest,
            NotImplementedException => HttpStatusCode.NotImplemented,
            _ => HttpStatusCode.InternalServerError
        };
            

        var response = ResponsesGenerationUtil.CreateProblemDetails(
                    "A problem was found",
                    statusCode.ToString(),
                    exception.Message,
                    (int)statusCode);

        return (statusCode, response);
    }
}
