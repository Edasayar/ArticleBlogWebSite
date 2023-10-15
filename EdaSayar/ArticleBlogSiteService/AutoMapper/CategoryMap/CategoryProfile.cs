
using ArticleBlogSiteEntity.DTOs.Category;
using ArticleBlogSiteEntity.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.AutoMapper.CategoryMap
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {

            CreateMap<CategoryDTO, Category>().ReverseMap();
        }
    }
}
