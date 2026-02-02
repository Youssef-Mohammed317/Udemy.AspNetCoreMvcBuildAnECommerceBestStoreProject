using BestStore.Shared.Result;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestStore.Application.Interfaces.Utility
{
    public interface IFileStorageService
    {
        Task<Result<string>> SaveAsync(IFormFile file, params string[] folders);
        Result Delete(string filePath);
    }

}
