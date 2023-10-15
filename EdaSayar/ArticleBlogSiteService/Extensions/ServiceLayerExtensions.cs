using ArticleBlogSiteDAL.Context;
using ArticleBlogSiteDAL.Repositories.Abstract;
using ArticleBlogSiteDAL.Repositories.Concrete;
using ArticleBlogSiteDAL.UnitOfWorks;
using ArticleBlogSiteDAL.UnitOfWorks.IdentityUnitOfWorks;
using ArticleBlogSiteEntity.Identity;
using ArticleBlogSiteService.Services.Abstract;
using ArticleBlogSiteService.Services.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Extensions
{
    public static class ServiceLayerExtensions
    {
        
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {       
            var assembly = Assembly.GetExecutingAssembly();


            //scoped şunun için ekledik IRepository çağırdığımızda Repository nesnesi oluşturması gerektiğini belirtiyoruz repository döndürüyor.
            services.AddScoped<IUnitOfWorkIdentity, UnitOfWorkIdentity>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IAppRoleService, AppRoleService>();
            services.AddScoped<ICommentService, CommentService>();

            


            services.AddAutoMapper(assembly);
            
            return services;
        }
    }
}
