using System.ComponentModel.DataAnnotations;

namespace BestStore.Web.Models.ViewModels.Account
{
    public class ResetPasswordViewModel
    {

        public string UserId { get; set; } 

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; } = "";

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = "";

        [Required]
        public string Token { get; set; } = "";
    }
}
