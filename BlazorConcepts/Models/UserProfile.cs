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

        
        [Required(ErrorMessage = "password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Stronger password required")]
        public string? Password { get; set; }

        
        [Required(ErrorMessage = "confirm password is required")]
        [Compare("Password", ErrorMessage ="the password and confirm password are not identical")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "phone number is required")]
        [Phone(ErrorMessage ="Invalid phone number")]
        public string? PhoneNumber { get; set; }





    }
}
