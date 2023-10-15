using ArticleBlogSiteEntity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Context.Data
{
    public class ArticleBlogSiteIdentityDbContext:IdentityDbContext<AppUser,AppRole, int>
    {
        public ArticleBlogSiteIdentityDbContext(DbContextOptions<ArticleBlogSiteIdentityDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

           
        }

        public virtual DbSet<AppUserRole> UserRoles { get; set; }
       


    }
}
