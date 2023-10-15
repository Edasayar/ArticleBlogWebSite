using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.AutoMapper.Articles
{
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDTO, Article>().ReverseMap();  //DTO sınıfındakilerle entity sınıfındakileri mapliyor, atricle çağırırsak articleDTO ile mapliyor,articleDTO çağırırsak article ile mapliyor.
           
			CreateMap<ArticleAddDTO, Article>().ReverseMap();

		}
    }
}
