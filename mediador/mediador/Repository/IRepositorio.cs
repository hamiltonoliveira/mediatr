using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Interface
{
    public interface IRepositorio<Tentity> where Tentity : class
    {
    Task<Tentity> GetByIdAsync(int id);
    Task<List<Tentity>> GetAsync(Expression<Func<Tentity, bool>> predicate);
    Task <List<Tentity>> GetAllAsync();
    Task InsertAsync(Tentity entity);
    Task UpdateAsync(Tentity entity);
    Task DeleteAsync(Tentity entity);
    IEnumerable<Tentity> Where(Expression<Func<Tentity, bool>> expression);
     
    }
}