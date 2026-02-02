using System;
using System.Collections.Generic;
using System.Text;

namespace BestStore.Application.Interfaces.Services
{
    public interface IDbInitializer
    {
        Task InitializeAsync();

    }
}
