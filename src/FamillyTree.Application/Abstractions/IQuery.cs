using FamillyTree.Application.Common;
using MediatR;

namespace FamillyTree.Application.Abstractions;

public interface IQuery<TResponse> : IRequest<ResultObject<TResponse>>
{
}
