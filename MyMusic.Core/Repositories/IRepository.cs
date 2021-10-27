﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MyMusic.Core.Models;
using MyMusic.Core.Specifications;

namespace MyMusic.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        ValueTask<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        Task<TEntity> GetEntityWithSpec(ISpecification<TEntity> spec);
        Task<IEnumerable<TEntity>> ListAsync(ISpecification<TEntity> spec);


    }
}