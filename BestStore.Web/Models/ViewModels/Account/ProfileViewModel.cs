using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BestStore.Web.Models.ViewModels.Account
{

    public class UpdateProfileViewModel
    {
        [Required]
        public string UserId { get; set; }
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
        public bool EmailConfirmed { get; set; }
        [AllowNull]
        public DateTime? CreatedAt { get; set; }
    }


}
