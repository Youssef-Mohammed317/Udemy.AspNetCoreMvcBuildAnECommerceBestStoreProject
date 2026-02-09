using BestStore.Application.Interfaces.Utility;
using BestStore.Shared.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace BestStore.Infrastructure.Utility
{
    public abstract class FileStorageServiceBase : IFileStorageService
    {
        protected readonly IHostEnvironment _env;

        protected FileStorageServiceBase(IHostEnvironment env)
        {
            _env = env;
        }

        public async Task<Result<string>> SaveAsync(IFormFile file, params string[] folders)
        {
            if (file == null)
                return Result<string>.Failure(Error.Failure($"Null.{nameof(file)}", "This file can't be null"));


            var uploadPath = BuildUploadPath(folders);
            EnsureDirectoryExists(uploadPath);

            var finalFileName = GenerateFileName(file.FileName);
            var fullPath = Path.Combine(uploadPath, finalFileName);

            using (var fs = new FileStream(fullPath, FileMode.Create))
            {
                try
                {
                    await file.CopyToAsync(fs);
                }
                catch
                {
                    return Result<string>.Failure(Error.Failure("IOError", "An error occurred while saving the file."));
                }
            }

            return Result<string>.Success(BuildRelativePath(finalFileName, folders));
        }

        public Result Delete(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                return Result.Failure(Error.Failure("Null", "File path is null"));

            var fullPath = Path.Combine(
                _env.ContentRootPath,
                "wwwroot",
                filePath.TrimStart('/')
            );

                fullPath = fullPath.Replace("/", "\\");
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
                return Result.Success();
            }
            return Result.Failure(Error.Failure("NotFound", "File path not found"));
        }


        protected virtual string GenerateFileName(string originalFileName)
        {
            var ext = Path.GetExtension(originalFileName);
            return $"{Guid.NewGuid()}_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}{ext}";
        }

        protected virtual string BuildUploadPath(params string[] folders)
        {
            var path = Path.Combine(_env.ContentRootPath, "wwwroot", "uploads");

            if (folders != null)
            {
                foreach (var folder in folders)

                    path = Path.Combine(path, folder);
            }

            return path;
        }

        protected virtual string BuildRelativePath(string fileName, params string[] folders)
        {
            var relative = "/uploads";

            if (folders != null && folders.Length > 0)
                relative += "/" + string.Join("/", folders);

            return $"{relative}/{fileName}";
        }

        protected static void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

    }
}
