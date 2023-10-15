using Microsoft.AspNetCore.Mvc;

namespace ArticleBlogSiteMVC.Areas.Admin.Controllers
{
    public class WriterController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
