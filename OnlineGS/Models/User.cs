using System.ComponentModel.DataAnnotations;

namespace OnlineGS.Models

{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public required string FullName { get; set; }


        [Required(ErrorMessage = "Email is required.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        public required string Role { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
