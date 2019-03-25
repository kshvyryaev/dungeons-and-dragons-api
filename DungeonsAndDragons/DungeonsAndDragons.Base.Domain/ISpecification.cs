using System;
using System.Linq.Expressions;

namespace DungeonsAndDragons.Base.Domain
{
    public interface ISpecification<TEntity>
        where TEntity : class
    {
        Expression<Func<TEntity, bool>> Predicate { get; }
    }
}
