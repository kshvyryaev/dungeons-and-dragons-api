﻿namespace DungeonsAndDragons.Domain.Contracts
{
    public interface ICommandValidator<in TCommand, in TSourceEntity>
        where TCommand : class, new()
        where TSourceEntity : class
    {
        void ValidateAndThrowIfFailed(TCommand command, TSourceEntity sourceEntity = null);
    }
}
