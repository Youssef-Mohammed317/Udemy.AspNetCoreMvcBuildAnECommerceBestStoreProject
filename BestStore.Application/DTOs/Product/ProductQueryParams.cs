namespace BestStore.Application.DTOs.Product
{
    public class ProductQueryParams
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string Search { get; set; } = string.Empty;
        public int? CategoryId { get; set; } = null!;
        public string SortBy { get; set; } = nameof(ProductDto.Name);
        public bool Ascending { get; set; } = true;
    }
}
