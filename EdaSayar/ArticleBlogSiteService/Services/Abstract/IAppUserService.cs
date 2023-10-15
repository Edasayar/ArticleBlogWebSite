using ArticleBlogSiteEntity.DTOs.AppRole;
using ArticleBlogSiteEntity.DTOs.AppUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Abstract
{
    public interface IAppUserService
    {
        Task<List<AppUserDTO>> GetAllAppUserAsync();
    }
}
