using BestStore.Application.DTOs.Product;
using System.ComponentModel.DataAnnotations;

namespace BestStore.Web.Models.ViewModels.Category
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
    public class CreateCategoryViewModel
    {

        [Required]
        public string Name { get; set; } = string.Empty;
    }
    public class UpdateCategoryViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
