using ArticleBlogSiteEntity.DTOs.AppRole;
using ArticleBlogSiteEntity.DTOs.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Abstract
{
    public interface IAppRoleService
    {
        Task<List<AppRoleDTO>> GetAllAppRoleAsync();
    }
}
