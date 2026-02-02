using BestStore.Application.DTOs.Product;
using BestStore.Shared.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestStore.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<Result<List<ProductDto>>> GetAllProductsAsync();
        Task<Result<ProductDetailsDto>> GetProductDetailsByIdAsync(int id);

        Task<Result<ProductDto>> CreateProductAsync(CreateProductDto productDto);
        Task<Result<ProductDto>> UpdateProductAsync(UpdateProductDto productDto);
        Task<Result<ProductDto>> GetProductByIdAsync(int id);
        Task<Result> DeleteProductAsync(int id);

        Task<Result<PaginatedResult<ProductDto>>> GetProductsPaginatedAsync(
        string search = null,
        int? category = null,
        string sortBy = nameof(ProductDto.Name),
        bool ascending = true,
        int pageNumber = 1,
        int pageSize = 10);
    }
}
