using System.ComponentModel.DataAnnotations;

namespace OnlineGS.Models
{
    public enum UserRole
    {
        Customer,
        Admin
    }
    public class Login
    {
        [Required,EmailAddress(ErrorMessage ="Email is required ")]
        public required string Email { get; set; }

        [Required,MinLength(6,ErrorMessage ="Password is required")]
        public required string Password { get; set; }

        [Required(ErrorMessage ="Role is required")]
        public UserRole Role { get; set; }

        public User User { get; set; }
        public int UserId { get; set;  }

    }
}
