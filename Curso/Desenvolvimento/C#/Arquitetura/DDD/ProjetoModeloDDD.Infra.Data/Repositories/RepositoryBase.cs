using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ProjetoModeloContext _dbContext;

        public RepositoryBase(ProjetoModeloContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task InsertAsync(TEntity obj)
        {
            await _dbContext.Set<TEntity>().AddAsync(obj);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(TEntity obj)
        {
            _dbContext.Set<TEntity>().Remove(obj);
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
        }
    }
}
