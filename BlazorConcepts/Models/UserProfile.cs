using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazorApp.Models
{
    public class UserProfile
    {
        [Required(ErrorMessage ="full name is required")]
        public string? FullName { get; set; }
        
        [Required(ErrorMessage = "email is required")]
        public string? Email { get; set; }
       
        [Required(ErrorMessage = "age is required")]
        public int? Age { get; set; }



    }
}
