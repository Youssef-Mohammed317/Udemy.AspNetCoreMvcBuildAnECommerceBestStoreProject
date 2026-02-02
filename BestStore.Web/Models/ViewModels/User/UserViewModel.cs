using BestStore.Web.Models.ViewModels.Product;

namespace BestStore.Web.Models.ViewModels.User
{
    public class UserViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string LastUpdatedAt { get; set; } = string.Empty;
        public List<string> Roles { get; set; }
        public bool EmailConfirmed { get; set; }
    }

}
