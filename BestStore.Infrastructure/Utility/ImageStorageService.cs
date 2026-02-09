using BestStore.Application.Interfaces.Utility;
using BestStore.Shared.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace BestStore.Infrastructure.Utility
{
    public class ImageStorageService : FileStorageServiceBase, IImageStorageService
    {
        private static readonly string[] AllowedExtensions =
        {
            ".jpg", ".jpeg", ".png", ".webp", ".gif"
        };

        public ImageStorageService(IHostEnvironment env)
            : base(env)
        {
        }

        public async Task<Result<string>> SaveImageAsync(
            IFormFile file,
            params string[] folders)
        {
            var result = ValidateImage(file.FileName);

            if (result.IsFailure)
            {
                return Result<string>.Failure(result.Error);
            }

            var finalFolders = new[] { "images" }
                .Concat(folders ?? Array.Empty<string>())
                .ToArray();

            return await SaveAsync(file, finalFolders);

        }

        public Result DeleteImage(string imagePath)
        {
            
            return Delete(imagePath);
        }

        private static Result ValidateImage(string fileName)
        {
            var ext = Path.GetExtension(fileName).ToLowerInvariant();

            if (!AllowedExtensions.Contains(ext))
            {
                return Result.Failure(Error.Failure("NotAllowed", "Only image files are allowed."));
            }
            return Result.Success();
        }
    }
}
