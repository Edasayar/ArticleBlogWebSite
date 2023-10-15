using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Repositories.IdentityRepositories.Abstract
{
    public interface IRepositoryIdentity<T> where T : class, IBaseEntity, new()
    {
        Task AddAsync(T entity); 

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

        //sadece bir tane veriyi döndürmek istiyorsak diye aşağıdaki metot. yukarıdakinden tek farkı bu
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int Id);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    }
}
