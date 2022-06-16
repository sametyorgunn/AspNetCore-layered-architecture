using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "lüften kullancı adı giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "lütfen şifrenizi giriniz.")]
        public string password { get; set; }
    }
}
