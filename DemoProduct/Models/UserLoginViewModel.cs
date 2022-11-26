using System.ComponentModel.DataAnnotations;

namespace DemoProduct.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
