using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.AppUser
{
    public class AppUserDTO
    {
        //[Display(Name = "Ad")]
        //[Required(ErrorMessage = "Lütfen ad giriniz")]
        //public string FirstName { get; set; }

        //[Display(Name = "Soyad")]
        //[Required(ErrorMessage = "Lütfen Soyad giriniz")]
        //public string LastName { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Şifre zorunludur.")]
        [MinLength(5, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }



        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
