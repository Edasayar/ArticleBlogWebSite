using ArticleBlogSiteDAL.Repositories.IdentityRepositories.Abstract;
using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.UnitOfWorks.IdentityUnitOfWorks
{
    public interface IUnitOfWorkIdentity:IAsyncDisposable
    {
        IRepositoryIdentity<T> GetRepositoryIdentity<T>() where T : class, IBaseEntity, new();
        Task<int> SaveAsync();

        int Save();

           
    }
}
