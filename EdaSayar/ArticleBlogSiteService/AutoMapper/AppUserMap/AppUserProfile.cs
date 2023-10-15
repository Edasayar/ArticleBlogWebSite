using ArticleBlogSiteEntity.DTOs.AppUser;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteEntity.Identity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.AutoMapper.AppUserMap
{
    public class AppUserProfile:Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUserDTO, AppUser>().ReverseMap();
        }
    }
}
