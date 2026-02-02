using System.ComponentModel.DataAnnotations;

namespace BestStore.Web.Models.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "The First Name field is required"), MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Last Name field is required"), MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "The format of the Phone Number is not valid"), MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Confirm Password field is required")]
        [Compare("Password", ErrorMessage = "Confirm Password and Password do not match")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must agree to the terms and conditions")]
        [Display(Name = "Terms and Conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms")]
        public bool AcceptTerms { get; set; } = false;
    }
    public class SendConfirmEmailViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
    public class EmailConfirmaitonViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;
    }
}
