using BestStore.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestStore.Application.DTOs.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
