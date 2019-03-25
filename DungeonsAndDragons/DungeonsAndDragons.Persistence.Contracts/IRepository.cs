﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DungeonsAndDragons.Base.Domain;

namespace DungeonsAndDragons.Persistence.Contracts
{
    public interface IRepository<TEntity, in TIdentifier>
        where TEntity : class
    {
        Task<IReadOnlyCollection<TEntity>> GetAllAsync();

        Task<TEntity> GetAsync(TIdentifier id);

        TEntity Get(TIdentifier id);

        Task<IReadOnlyCollection<TEntity>> FindAllAsync(ISpecification<TEntity> specification);

        Task<TEntity> FindAsync(ISpecification<TEntity> specification);

        TEntity Find(ISpecification<TEntity> specification);

        Task<TEntity> SaveAsync(TEntity entity);

        Task DeleteAsync(TIdentifier id);
    }
}
