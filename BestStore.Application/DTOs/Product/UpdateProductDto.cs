using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BestStore.Application.DTOs.Product
{
    public class UpdateProductDto
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        [Required]
        public string Brand { get; set; } = string.Empty;
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        public IFormFile? ImageFile { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
