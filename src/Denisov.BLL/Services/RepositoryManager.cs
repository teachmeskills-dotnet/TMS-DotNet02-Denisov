using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Denisov.Common.Interfaces;
using Denisov.DAL;
using Microsoft.EntityFrameworkCore;

namespace Denisov.BLL.Services
{
    /// <summary>
    /// Manager of entity repository.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public class RepositoryManager<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _context;

        /// <summary>
        /// Constructor of repository manager.
        /// </summary>
        /// <param name="context">Application DB context.</param>
        public RepositoryManager(DenisovDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        /// <inheritdoc/>
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        /// <inheritdoc/>
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        /// <inheritdoc/>
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        /// <inheritdoc/>
        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        /// <inheritdoc/>
        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        /// <inheritdoc/>
        public async Task<T> GetEntityAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        /// <inheritdoc/>
        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}