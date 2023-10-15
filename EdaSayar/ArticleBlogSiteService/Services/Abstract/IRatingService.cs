using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.DTOs.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Abstract
{
    public interface IRatingService
    {
        Task<List<RatingDTO>> GetAllRatingAsync();
    }
}
