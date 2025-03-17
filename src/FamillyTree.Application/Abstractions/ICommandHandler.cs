﻿using FamillyTree.Application.Common;
using MediatR;

namespace FamillyTree.Application.Abstractions;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, ResultObject>
    where TCommand : ICommand
{
}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, ResultObject<TResponse>>
    where TCommand : ICommand<TResponse>
{
}
