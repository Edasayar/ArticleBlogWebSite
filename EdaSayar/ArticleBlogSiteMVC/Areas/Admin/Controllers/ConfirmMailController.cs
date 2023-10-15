using ArticleBlogSiteEntity.Identity;
using ArticleBlogSiteMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArticleBlogSiteMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class ConfirmMailController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

        public ConfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
		public IActionResult Index(int Id)
		{
			var value = TempData["Mail"];
			ViewBag.v=value; 
			return View();
		}

        [HttpPost]
        public async  Task<IActionResult> Index(ConfirmMailVM cmVm)
        {
            var user = await _userManager.FindByEmailAsync(cmVm.Mail);
            if (user!=null && user.ConfirmCode == cmVm.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "MyProfile");
            }
            else
            {
				ModelState.AddModelError(string.Empty, "Doğrulama kodu yanlış.");
				return View(cmVm);
			}
            return View();
        }
    }
}
