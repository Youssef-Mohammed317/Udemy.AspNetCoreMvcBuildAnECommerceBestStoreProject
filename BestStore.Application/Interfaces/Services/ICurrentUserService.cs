namespace BestStore.Application.Interfaces.Services
{
    public interface ICurrentUserService
    {
        bool IsAuthenticated { get; }
        string? UserId { get; }
    }
}
