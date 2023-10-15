using ArticleBlogSiteDAL.UnitOfWorks;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteService.Services.Abstract;
using ArticleBlogSiteCore.IBaseRepositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ArticleBlogSiteDAL.Context;

namespace ArticleBlogSiteService.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
       private readonly ArticleBlogSiteDbContext _dbContext;
        private readonly ClaimsPrincipal _user;

        public ArticleService(ArticleBlogSiteDbContext dbContext, IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
           _dbContext = dbContext;
        }

        public async Task CreateArticleAsync(ArticleAddDTO articleAddDto)
        {
            try
            {
                //bunun yeri burası değil taşımayı unutma
                var article = new Article
                {
                    Title = articleAddDto.Title,
                    Content = articleAddDto.Content,
                    Image = articleAddDto.Image,
                    CategoryId = articleAddDto.CategoryId

                };


                _dbContext.Articles.Add(article);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Makale oluşturma sırasında bir hata oluştu.", ex);
            }
        }

        public Task<List<ArticleDTO>> GetArticleWithCategoryNonDeletedAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ArticleDTO>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<ArticleDTO>>(articles);

            return map;
        }

        public Task<ArticleListDTO> GetAllByPagingAsync(int? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            throw new NotImplementedException();
        }

        public async Task<ArticleDTO> GetArticleWithCategoryNonDeletedAsync(int articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.ID == articleId, x => x.Category, i => i.Image, u => u.UserId);
            var map = mapper.Map<ArticleDTO>(article);

            return map;
        }

        public Task<string> SafeDeleteArticleAsync(int articleId)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleListDTO> SearchAsync(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            throw new NotImplementedException();
        }

        

        public async Task<string> UndoDeleteArticleAsync(int articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByIntAsync(articleId);

            article.IsDeleted = false;
            article.DeletedDate = null;
            article.DeletedBy = null;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

            return article.Title;
        }

        public Task<string> UpdateArticleAsync(ArticleUpdateDTO articleUpdateDto)
        {
            throw new NotImplementedException();
        }

        Task<int> IArticleService.SafeDeleteArticleAsync(int articleId)
        {
            throw new NotImplementedException();
        }

        Task<int> IArticleService.UndoDeleteArticleAsync(int articleId)
        {
            throw new NotImplementedException();
        }

		public Task<string?> CreateArticleAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<List<ArticleDTO>> GetLatestArticlesAsync(int count)
		{
			try
			{
				var latestArticles = await unitOfWork.GetRepository<Article>()
					.GetAllAsync(x => !x.IsDeleted, x => x.Category);

				var orderedArticles = latestArticles
					.OrderByDescending(article => article.CreatedDate) // DateAdded veya makalenin eklenme tarihine uygun bir özellik kullanın
					.Take(count)
					.ToList(); // ToList() metodu ile koleksiyonu liste olarak çevirin

				var mappedArticles = mapper.Map<List<ArticleDTO>>(orderedArticles);

				return mappedArticles;
			}
			catch (Exception ex)
			{
				throw new Exception("En son eklenen makaleleri getirirken bir hata oluştu.", ex);
			}
		}
	}
}