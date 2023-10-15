using ArticleBlogSiteDAL.Context;
using ArticleBlogSiteDAL.Repositories.Abstract;
using ArticleBlogSiteDAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArticleBlogSiteDbContext _db;

        public UnitOfWork(ArticleBlogSiteDbContext db)
        {
             _db = db;
        }

       
        public async ValueTask DisposeAsync()
        {
            await _db.DisposeAsync();
        }

        public int Save()
        {
           return  _db.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(_db);
        }
    }
}
