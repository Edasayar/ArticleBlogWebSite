using Microsoft.AspNetCore.Mvc;

namespace ArticleBlogSiteMVC.Areas.Admin.Controllers
{
    public class MyProfileController : Controller
    {
        
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
