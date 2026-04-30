using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazorApp.Models
{
    public class UserProfile
    {
        [Required(ErrorMessage ="full name is required")]
        [StringLength(30, ErrorMessage = "full name cannot be more than 30 characters")]

        public string? FullName { get; set; }
        
        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage = "invalid email format")]
        public string? Email { get; set; }
       
        [Required(ErrorMessage = "age is required")]
        [Range(10, 70, ErrorMessage = "age must be between 10 and 70")]
        public int? Age { get; set; }



    }
}
