using ArticleBlogSiteDAL.Repositories.Abstract;
using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.UnitOfWorks
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        
        IRepository<T> GetRepository<T>() where T : class, IBaseEntity, new();

       

        Task<int> SaveAsync();

        int Save();
    }
}
