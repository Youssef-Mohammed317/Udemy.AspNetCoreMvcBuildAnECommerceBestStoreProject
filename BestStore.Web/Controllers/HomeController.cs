using AutoMapper;
using BestStore.Application.DTOs.Product;
using BestStore.Application.Interfaces.Services;
using BestStore.Web.Models.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace BestStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public HomeController(IProductService productService, IMapper mapper)
        {
            this._productService = productService;
            this._mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetProductsPaginatedAsync(sortBy: nameof(ProductDto.CreatedAt),
                ascending: false,
                pageSize: 4);

            if (result.IsFailure)
            {
                return NotFound();
            }
            var viewModels = _mapper.Map<List<ProductViewModel>>(result.Value.Items);

            return View(viewModels);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Terms()
        {
            return View();
        }
    }
}
