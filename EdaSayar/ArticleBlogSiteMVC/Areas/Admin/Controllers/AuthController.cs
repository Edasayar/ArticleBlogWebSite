using ArticleBlogSiteEntity.DTOs;
using ArticleBlogSiteEntity.DTOs.AppUser;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Identity;
using ArticleBlogSiteMVC.Areas.Admin.Models;
using ArticleBlogSiteService.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;


namespace ArticleBlogSiteMVC.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
    public class AuthController : Controller
    {
       

       // private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IAppUserService _appUserService;
       


        public AuthController( SignInManager<AppUser> signInManager, IAppUserService appUserService)
        {
           // _userManager = userManager;
            _signInManager = signInManager;
            _appUserService = appUserService;
            
        }

        public async Task<IActionResult> Login()
        {
            return View();
            //var users = await _appUserService.GetAllAppUserAsync();
            //return View(users);
        }


        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserSignInVM u)
        {
            if (ModelState.IsValid)
            {
				var result = await _signInManager.PasswordSignInAsync(u.UserName,u.Password,false,true);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Article");
                }
                else
                {
					 ModelState.AddModelError(string.Empty, "Giriş başarısız. Lütfen kullanıcı adı ve şifrenizi kontrol edin.");
                    return View();

                }

			}
            else
            {
                ModelState.AddModelError(string.Empty, "Giriş başarısız. Lütfen kullanıcı adı ve şifrenizi kontrol edin.");
                return View(u); // Hata ile birlikte kullanıcının giriş sayfasında kalması için kullanıcı modelini geri döndürün
            }
           

           
        }

		[Authorize]
		[HttpGet]
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Login", "Auth");
		}

		[Authorize]
		[HttpGet]
		public async Task<IActionResult> AccessDenied()
		{
			return View();
		}






	}
}
