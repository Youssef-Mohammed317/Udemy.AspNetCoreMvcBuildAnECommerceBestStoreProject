using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace BestStore.Application.DTOs.Product
{
    public class CreateProductDto
    {
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
        public int StockQuantity { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
