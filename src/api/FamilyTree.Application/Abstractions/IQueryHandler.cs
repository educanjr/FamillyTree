using FamilyTree.Application.Common;
using MediatR;

namespace FamilyTree.Application.Abstractions;

public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, ResultObject<TResponse>> where TQuery : IQuery<TResponse>
{
}

