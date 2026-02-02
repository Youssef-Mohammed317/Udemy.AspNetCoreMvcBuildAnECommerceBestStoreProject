using BestStore.Shared.Result;
using Microsoft.AspNetCore.Http;

namespace BestStore.Application.Interfaces.Utility
{
    public interface IImageStorageService
    {
        Task<Result<string>> SaveImageAsync(IFormFile file, params string[] folders);
        Result DeleteImage(string imagePath);
    }

}
