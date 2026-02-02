namespace BestStore.Application.DTOs.Account
{
    public class EmailConfirmaitonDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;
    }
}
