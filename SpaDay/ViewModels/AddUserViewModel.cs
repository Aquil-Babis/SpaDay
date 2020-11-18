using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5-15 characters.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Invalid password.  Must have 6-20 characters.")]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Verification required.")]
        [Compare("Password", ErrorMessage = "Verification does not match Password.")]

        public string Verify { get; set; }
    }
}
