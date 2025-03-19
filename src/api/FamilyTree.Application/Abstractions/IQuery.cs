using FamilyTree.Application.Common;
using MediatR;

namespace FamilyTree.Application.Abstractions;

public interface IQuery<TResponse> : IRequest<ResultObject<TResponse>>
{
}
