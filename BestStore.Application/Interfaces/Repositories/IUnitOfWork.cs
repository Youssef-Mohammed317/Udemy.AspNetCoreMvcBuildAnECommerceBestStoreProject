using BestStore.Shared.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestStore.Application.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
        public ICategoryRepository CategoryRepository { get; }

        public Task<Result> SaveChangesAsync();
    }
}
