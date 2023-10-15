using ArticleBlogSiteEntity.DTOs.AppRole;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteEntity.Identity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.AutoMapper.AppRoleMap
{
    public class AppRoleProfile:Profile
    {
        public AppRoleProfile()
        {
            CreateMap<AppRoleDTO, AppRole>().ReverseMap();
        }
    }
}
