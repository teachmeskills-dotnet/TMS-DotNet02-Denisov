using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Denisov.Common.Interfaces
{
    /// <summary>
    /// Interface to manage entities in application DB context.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get all queries.
        /// </summary> 
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Get entity asynchronously by predicate.
        /// </summary>
        /// <param name="predicate">LINQ predicate.</param>
        /// <returns>T entity.</returns>
        Task<T> GetEntityAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Add new entity asenchronously.
        /// </summary>
        /// <param name="entity">New entity.</param>
        Task AddAsync(T entity);

        /// <summary>
        /// Add a collection of new entities asynchronously.
        /// </summary>
        /// <param name="entities">Entities collection.</param>
        Task AddRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// Update entity.
        /// </summary>
        /// <param name="entity">Entity to update.</param>
        void Update(T entity);

        /// <summary>
        /// Remove entity.
        /// </summary>
        /// <param name="entity">Entity to remove.</param>
        void Remove(T entity);

        /// <summary>
        /// Remove collection of entities.
        /// </summary>
        /// <param name="entities">Collection of entities.</param>
        void RemoveRange(IEnumerable<T> entities);

        /// <summary>
        /// Persists all updated for database asynchronously.
        /// </summary>
        Task SaveChangesAsync();
    }
}