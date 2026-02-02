using BestStore.Application.Interfaces.Services;
using BestStore.Infrastructure.Contexts.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BestStore.Infrastructure.Contexts
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public DbInitializer(
            ApplicationDbContext context,
            IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public async Task InitializeAsync()
        {

            await _context.Database.MigrateAsync();
            await DefaultRolesSeed.SeedAsync(_serviceProvider);
            await DefaultUsersSeed.SeedAsync(_serviceProvider);
            await BusinessDataSeed.SeedAsync(_context);
        }
    }
}