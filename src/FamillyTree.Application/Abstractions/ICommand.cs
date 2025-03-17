using FamillyTree.Application.Common;
using MediatR;

namespace FamillyTree.Application.Abstractions;

public interface ICommand : IRequest<ResultObject>
{
}

public interface ICommand<TResponse> : IRequest<ResultObject<TResponse>>
{
}
