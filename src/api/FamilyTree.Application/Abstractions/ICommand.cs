using FamilyTree.Application.Common;
using MediatR;

namespace FamilyTree.Application.Abstractions;

public interface ICommand : IRequest<ResultObject>
{
}

public interface ICommand<TResponse> : IRequest<ResultObject<TResponse>>
{
}
