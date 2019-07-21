using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Infra.Interface;
using mediador.Contexto;
using Microsoft.EntityFrameworkCore;

namespace mediador.Repository
{

    public class Repositorio<Tentity> : IRepositorio<Tentity> where Tentity : class
    {
        public DbSet<Tentity> DbSet
        {
            get;
            set;
        }
        protected readonly ContextoDB _dbcontext;

        public Repositorio(ContextoDB dbcontext)
        {


            _dbcontext = dbcontext;
        }

        public async Task DeleteAsync(Tentity entity)
        {
            _dbcontext.Set<Tentity>().Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<Tentity>> GetAllAsync()
        {
            return await _dbcontext.Set<Tentity>().ToListAsync();
        }

        public async Task<Tentity> GetByIdAsync(int id)
        {
            return await _dbcontext.Set<Tentity>().FindAsync(id);
        }


        public IEnumerable<Tentity> Where(Expression<Func<Tentity, bool>> expression)
        {
            return this.DbSet.Where(expression);
        }

        public async Task InsertAsync(Tentity entity)
        {
            _dbcontext.Set<Tentity>().Add(entity);
            await _dbcontext.SaveChangesAsync();
        }


        public async Task UpdateAsync(Tentity entity)
        {
            _dbcontext.Entry(entity).State = EntityState.Modified;
            _dbcontext.Update(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public Task<List<Tentity>> GetAsync(Expression<Func<Tentity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}