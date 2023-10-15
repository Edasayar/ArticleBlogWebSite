using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Articles
{
    public class RegisterDTO
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Lütfen ad giriniz")]
        public string FirstName { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Lütfen Soyad giriniz")]
        public string LastName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler aynı olmalıdır!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required( ErrorMessage = "Lütfen mail adresi giriniz")]
        public string Email { get; set; }








    }
}
