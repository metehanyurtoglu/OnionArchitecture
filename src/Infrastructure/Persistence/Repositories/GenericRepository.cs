using Application.Interfaces.Repositories;
using Domain.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this.dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await this.dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            await this.dbContext.Set<T>().AddAsync(entity);
            await this.dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> UpdateAsync(Guid id, T entity)
        {
            EntityEntry entityEntry = this.dbContext.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await this.dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await this.dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            EntityEntry entityEntry = this.dbContext.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await this.dbContext.SaveChangesAsync();
        }
    }
}
