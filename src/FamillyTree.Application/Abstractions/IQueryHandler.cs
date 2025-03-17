using FamillyTree.Application.Common;
using MediatR;

namespace FamillyTree.Application.Abstractions;

public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, ResultObject<TResponse>> where TQuery : IQuery<TResponse>
{
}

