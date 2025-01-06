using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OnlineGS.Models
{
    public class Register
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public required string Email { get; set; }

        [Required]
        public string FullName { get; set; }


        [Required(ErrorMessage ="Please enter Password")]
        [MinLength(6,ErrorMessage ="Password must be atleast 6 characters")]
        public required string Password { get; set; }


        [Required,Compare("Password",ErrorMessage ="Password do not match")]
        public required string ConfirmPassword { get; set; }



        [Required]
        public required string Role {  get; set; }


    }
}
