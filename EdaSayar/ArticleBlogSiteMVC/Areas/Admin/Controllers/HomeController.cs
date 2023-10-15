using ArticleBlogSiteService.Services.Abstract;
using ArticleBlogSiteService.Services.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ArticleBlogSiteMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
       
        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
          
        }

        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetArticleWithCategoryNonDeletedAsync();

            return View(articles);


        }

       
    }
}
