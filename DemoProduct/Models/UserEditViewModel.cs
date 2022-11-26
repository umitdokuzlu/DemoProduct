using System.ComponentModel.DataAnnotations;

namespace DemoProduct.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyet Seçiniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olun")]
        public string ConfirmPassword { get; set; }

    }
}
