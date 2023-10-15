using ArticleBlogSiteDAL.UnitOfWorks.IdentityUnitOfWorks;
using ArticleBlogSiteEntity.DTOs.AppUser;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteEntity.Identity;
using ArticleBlogSiteService.Services.Abstract;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Concrete
{
    public class AppUserService:IAppUserService
    {
        private readonly IUnitOfWorkIdentity _unitOfWorkIdentity;
        private readonly IMapper _mapper;

        public AppUserService(IUnitOfWorkIdentity unitOfWorkIdentity, IMapper mapper)
        {
            _unitOfWorkIdentity = unitOfWorkIdentity;
            _mapper = mapper;
        }

        public async Task<List<AppUserDTO>> GetAllAppUserAsync()
        {
            var user = await _unitOfWorkIdentity.GetRepositoryIdentity<AppUser>().GetAllAsync();
            var map = _mapper.Map<List<AppUserDTO>>(user);
            return map;
        }

       
    }
}
