using System.ComponentModel.DataAnnotations;

namespace BestStore.Application.DTOs.Account
{
    public class ResetPasswordDto
    {
        [Required]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; } = "";

        [Required]
        public string Token { get; set; } = "";
    }
}
