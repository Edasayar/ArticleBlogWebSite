using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.Identity;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace ArticleBlogSiteMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
             _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterDTO registerDTO)
        {
            if(ModelState.IsValid)
            {
                Random random = new Random();
                int code;
                code = random.Next(100000, 1000000);

				AppUser appUser = new AppUser()
                {
                    UserName = registerDTO.UserName,
                    FirstName=registerDTO.FirstName,   
                    LastName=registerDTO.LastName,  
                    Email = registerDTO.Email,
                    Image="image.jpg",
                    ConfirmCode=code
                    

                };
                var result = await _userManager.CreateAsync(appUser, registerDTO.Password);
                if(result.Succeeded)
                {
                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "esedasayar@gmail.com");
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);
                    
                    mimeMessage.From.Add(mailboxAddressFrom);
                    mimeMessage.To.Add(mailboxAddressTo);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Kayıt işlemini gerçekleştirmek için onay kodunuz:" + code;
                    mimeMessage.Body = bodyBuilder.ToMessageBody();
                    mimeMessage.Subject = "Bilgi Atlası Onay Kodu";

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Connect("smtp.gmail.com", 587, false);
                    smtpClient.Authenticate("esedasayar@gmail.com", "loktoejokasyckbr");
                    smtpClient.Send(mimeMessage);
                    smtpClient.Disconnect(true);

                    TempData["Mail"] = registerDTO.Email;

                    return RedirectToAction("Index","ConfirmMail");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
               
            }
            return View();
        }
    }
}
