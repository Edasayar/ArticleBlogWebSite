using System.ComponentModel.DataAnnotations;

namespace ArticleBlogSiteMVC.Areas.Admin.Models
{
	public class UserSignInVM
	{
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
		public string Password { get; set; }
    }
}
