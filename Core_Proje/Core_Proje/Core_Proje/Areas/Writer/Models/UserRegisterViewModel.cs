using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı Girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen resim url değeri Girin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar Girin")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen mail Girin")]
        public string Mail { get; set; }
    }
}
