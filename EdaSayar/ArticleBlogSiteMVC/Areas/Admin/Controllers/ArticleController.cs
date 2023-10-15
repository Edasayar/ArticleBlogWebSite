using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteMVC.Roles;
using ArticleBlogSiteService.Services.Abstract;
using ArticleBlogSiteService.Services.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ArticleBlogSiteMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IRatingService _ratingService;
        private readonly IMapper _mapper;
        private readonly ICommentService _commentService;
        

        public ArticleController(IArticleService articleService, ICommentService commentService, ICategoryService categoryService, IRatingService ratingService, IMapper mapper)
        {
             _articleService = articleService;
             _categoryService = categoryService;
             _ratingService = ratingService;
             _commentService=commentService;
             _mapper=mapper;
        }

        //[HttpGet]
        //[Authorize(Roles = $"{RoleConsts.Admin}, {RoleConsts.Writer},{RoleConsts.User}, {RoleConsts.Visitor}")]
        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }
        // Authorize yaptığımızda bu sayfaları kimler görüntüleyebilir bunu belirtmiş oluyoruz 
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Admin},{RoleConsts.Writer},{RoleConsts.User}")]
        public async Task<IActionResult> DeletedArticle()
        {
            var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Admin},{RoleConsts.Writer},{RoleConsts.User}")]
        public async Task<IActionResult> CreateArticle()
        {
            var articles = await _articleService.CreateArticleAsync();
            return View(articles);
        }

       

        //[HttpPost]
        //[Authorize(Roles = $"{RoleConsts.Admin},{RoleConsts.Writer},{RoleConsts.User}")]
        public async Task<IActionResult> DetailArticle()
        {
            var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }

        public async Task<IActionResult> GetLatestArticles(int count)
        {
            var articles = await _articleService.GetLatestArticlesAsync(count);
            return View(articles);
        }




	}
}
