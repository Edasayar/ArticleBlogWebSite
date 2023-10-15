using ArticleBlogSiteDAL.UnitOfWorks;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.DTOs.Rating;
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
    public class RatingService : IRatingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RatingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<RatingDTO>> GetAllRatingAsync()
        {
            var rating = await _unitOfWork.GetRepository<Rating>().GetAllAsync();
            var map = _mapper.Map<List<RatingDTO>>(rating);
            return map;
        }
    }
}
