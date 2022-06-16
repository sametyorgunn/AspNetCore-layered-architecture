using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string namesurname { get; set; }
        public string imgUrl { get; set; }
    }
}
