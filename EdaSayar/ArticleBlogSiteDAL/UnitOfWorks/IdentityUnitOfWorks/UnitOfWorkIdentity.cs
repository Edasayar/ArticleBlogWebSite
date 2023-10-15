using ArticleBlogSiteDAL.Context.Data;
using ArticleBlogSiteDAL.Repositories.Concrete;
using ArticleBlogSiteDAL.Repositories.IdentityRepositories.Abstract;
using ArticleBlogSiteDAL.Repositories.IdentityRepositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.UnitOfWorks.IdentityUnitOfWorks
{
    public class UnitOfWorkIdentity : IUnitOfWorkIdentity
    {
        private readonly ArticleBlogSiteIdentityDbContext _db;

        public UnitOfWorkIdentity(ArticleBlogSiteIdentityDbContext db)
        {
            _db = db;
        }
        public async ValueTask DisposeAsync()
        {
            await _db.DisposeAsync();
        }

        public int Save()
        {
            return _db.SaveChanges();
        }

        public  async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }

        IRepositoryIdentity<T> IUnitOfWorkIdentity.GetRepositoryIdentity<T>()
        {
            return new RepositoryIdentity<T>(_db);
        }
    }
}
