using ArticleBlogSiteDAL.Context;
using ArticleBlogSiteDAL.Context.Data;
using ArticleBlogSiteDAL.Repositories.Abstract;
using ArticleBlogSiteDAL.Repositories.Concrete;
using ArticleBlogSiteDAL.Repositories.IdentityRepositories.Abstract;
using ArticleBlogSiteDAL.Repositories.IdentityRepositories.Concrete;
using ArticleBlogSiteDAL.UnitOfWorks;
using ArticleBlogSiteEntity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration configuration)
        {           //scoped şunun için ekledik IRepository çağırdığımızda Repository nesnesi oluşturması gerektiğini belirtiyoruz repository döndürüyor.
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IRepositoryIdentity<>), typeof(RepositoryIdentity<>));


            
            //var userManager = service.GetRequiredService<UserManager<AppUser>>();
            //var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();





            services.AddDbContext<ArticleBlogSiteDbContext>(opt =>
            {
                string blogSiteDb = "Server=EDA\\MSSQLSERVER01;Database=ArticleBlogSiteDb;Trusted_Connection=True;";
                opt.UseSqlServer(blogSiteDb);
                opt.UseLazyLoadingProxies();

            }).AddDbContext<ArticleBlogSiteIdentityDbContext>(opt =>
            {
                string blogSiteIdentityDb = "Server=EDA\\MSSQLSERVER01;Database=ArticleBlogSiteIdentityDb;Trusted_Connection=True;";
                opt.UseSqlServer(blogSiteIdentityDb);
                opt.UseLazyLoadingProxies();
            });


            services.AddIdentityCore<AppUser>().AddRoles<AppRole>().AddEntityFrameworkStores<ArticleBlogSiteIdentityDbContext>();

            //aşağıdaki kod sistem hata durumlarına karşı daha dayanıklı hale gelir ve geçici sorunlar nedeniyle oluşan istisnaları daha az a indiriyor
            services.AddDbContext<ArticleBlogSiteIdentityDbContext>(options =>
            {
                options.UseSqlServer("Server=EDA\\MSSQLSERVER01;Database=ArticleBlogSiteIdentityDb;Trusted_Connection=True;", sqlServerOptions =>
                {
                    sqlServerOptions.EnableRetryOnFailure();
                });
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;


        }
    }
}
