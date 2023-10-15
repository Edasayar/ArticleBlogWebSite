using ArticleBlogSiteDAL.UnitOfWorks;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.DTOs.Comment;
using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteService.Services.Abstract;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<CommentDTO>> GetAllCommentsAsync()
        {
            var article = await _unitOfWork.GetRepository<Comment>().GetAllAsync();
            var map = _mapper.Map<List<CommentDTO>>(article);
            return map;
        }
    }
}
