using BestStore.Web.Models.ViewModels.Category;
using System.ComponentModel.DataAnnotations;

namespace BestStore.Web.Models.ViewModels.Product
{
    public class CreateProductViewModel
    {

        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        [Required]
        public string Brand { get; set; } = string.Empty;
        [Required(ErrorMessage = "This Field is required")]
        public int CategoryId { get; set; }
        public List<CategorySelectPairViewModel> CategorySelectPairs { get; set; }
            = new();
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}

