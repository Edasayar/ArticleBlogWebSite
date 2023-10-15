using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Abstract
{
    public interface IArticleService
    {
		Task<List<ArticleDTO>> GetLatestArticlesAsync(int count);
		Task<List<ArticleDTO>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task<List<ArticleDTO>> GetArticleWithCategoryNonDeletedAsync();
        Task<ArticleDTO> GetArticleWithCategoryNonDeletedAsync(int articleId);
        Task CreateArticleAsync(ArticleAddDTO articleAddDto);
        Task<string> UpdateArticleAsync(ArticleUpdateDTO articleUpdateDto);
        Task<int> SafeDeleteArticleAsync(int articleId);
        Task<int> UndoDeleteArticleAsync(int articleId);
        Task<ArticleListDTO> GetAllByPagingAsync(int? categoryId, int currentPage = 1, int pageSize = 3,
            bool isAscending = false);

        Task<ArticleListDTO> SearchAsync(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false);
		Task<string?> CreateArticleAsync();
	}

}


