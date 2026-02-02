using BestStore.Application.Interfaces.Repositories;
using BestStore.Infrastructure.Contexts;
using BestStore.Shared.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestStore.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IProductRepository ProductRepository
        {
            get
            {

                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_context);
                }
                return _productRepository;
            }
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {

                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_context);
                }
                return _categoryRepository;
            }
        }

        public async Task<Result> SaveChangesAsync()
        {
            try
            {

                await _context.SaveChangesAsync();
                return Result.Success();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Result.Failure(
                    Error.Failure(
                        "concurrency_error",
                        "A concurrency error occurred while saving changes to the database."
                    )
                );
            }
            catch (DbUpdateException)
            {
                return Result.Failure(
                    Error.Failure(
                        "database_update_error",
                        "An error occurred while updating the database."
                    )
                );
            }

        }
    }
}
