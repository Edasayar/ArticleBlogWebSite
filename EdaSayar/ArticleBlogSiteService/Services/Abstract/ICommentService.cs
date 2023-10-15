using ArticleBlogSiteEntity.DTOs.Category;
using ArticleBlogSiteEntity.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Abstract
{
    public interface ICommentService
    {
        Task<List<CommentDTO>> GetAllCommentsAsync();
        
    }
}
