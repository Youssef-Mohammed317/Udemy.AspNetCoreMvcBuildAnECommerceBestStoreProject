namespace BestStore.Application.DTOs.Account
{
    public class ForgotPasswordDto
    {
        public string Email { get; set; } = "";
        public string Id { get; set; }
        public string Token { get; set; }
    }
}
