using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "lütfen rol giriniz")]
        public string name { get; set; }
    }
}
