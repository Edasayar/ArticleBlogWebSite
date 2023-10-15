using ArticleBlogSiteDAL.UnitOfWorks;
using ArticleBlogSiteDAL.UnitOfWorks.IdentityUnitOfWorks;
using ArticleBlogSiteEntity.DTOs.AppRole;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteEntity.Identity;
using ArticleBlogSiteService.Services.Abstract;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Concrete
{
   
    
    public class AppRoleService : IAppRoleService
    {
       
        private readonly IUnitOfWorkIdentity unitOfWorkIdentity;
        private readonly IMapper mapper;

        public AppRoleService(IUnitOfWorkIdentity unitOfWorkIdentity, IMapper mapper)
        {
            this.unitOfWorkIdentity = unitOfWorkIdentity;
            this.mapper = mapper;
        }
        public async Task<List<AppRoleDTO>> GetAllAppRoleAsync()
        {
            var appRole = await unitOfWorkIdentity.GetRepositoryIdentity<AppRole>().GetAllAsync();  //AppRole ı IBaseIdentityden de türettim bi sorun çıkarsa buraya bakmayı unutma
            var map = mapper.Map<List<AppRoleDTO>>(appRole);
            return map;
        }
    }
}
