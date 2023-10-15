using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteCore.IBaseRepositories
{
    public interface IBaseRepository<T> where T : class, new()
    {
        Task<T> Create(T Entity);
        Task<T> Update(T Entity);
        Task<T> Delete(T Entity);
        Task<T> Any(Expression<Func<T, bool>> filter);
        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter);
        Task<T> GetFiltredFirstOrDefault<R>(Expression<Func<T, R>> select,
            Expression<Func<T, bool>> where,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            params Expression<Func<T, object>>[] inculudes);

        //ICollection<T> GetFilteredList<T, R>(
        //Expression<Func<T, R>> select,
        //Expression<Func<T, bool>> where,
        //Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //params Expression<Func<T, object>>[] includes);


    }
}
