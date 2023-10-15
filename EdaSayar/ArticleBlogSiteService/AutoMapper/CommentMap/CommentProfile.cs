using ArticleBlogSiteEntity.DTOs.Comment;
using ArticleBlogSiteEntity.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.AutoMapper.CommentMap
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentDTO, Comment>().ReverseMap();
        }
    }
}
