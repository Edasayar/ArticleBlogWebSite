using ArticleBlogSiteEntity.DTOs.Rating;
using ArticleBlogSiteEntity.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.AutoMapper.RatingMap
{
    public class RatingProfile:Profile
    {
        public RatingProfile()
        {
            CreateMap<RatingDTO, Rating>().ReverseMap();
        }
    }
}
