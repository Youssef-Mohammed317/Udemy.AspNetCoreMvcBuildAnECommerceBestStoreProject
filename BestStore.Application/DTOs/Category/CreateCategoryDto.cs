using System.ComponentModel.DataAnnotations;

namespace BestStore.Application.DTOs.Category
{
    public class CreateCategoryDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
