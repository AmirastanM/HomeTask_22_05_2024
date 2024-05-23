using FiorelloBack.Data;
using FiorelloBack.Services.Interfaces;
using FiorelloBack.ViewModels;
using FiorelloBack.ViewModels.Baskets;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FiorelloBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IHttpContextAccessor _accessor;
        public HomeController(ISliderService sliderService,
                             IBlogService blogService,
                             ICategoryService categoryService,
                             IProductService productService,
                             IHttpContextAccessor accessor)
        {
            _sliderService = sliderService;
            _categoryService = categoryService;
            _productService = productService;
            _blogService = blogService;
            _accessor = accessor;
        }

        public async Task<IActionResult> Index()
        {
            
            HomeVM model = new()
            {
               Sliders = await _sliderService.GetAllAsync(),
               SliderInfo = await _sliderService.GetSliderInfoAsync(),
               Blogs = await _blogService.GetAllAsync(3),
               Categories = await _categoryService.GetAllAsync(),
               Products = await _productService.GetAllAsync(),

            };


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProductToBasket(int? id)
        {
            if (id is null) return BadRequest();

            var product = await _productService.GetByIdAsync((int)id);

            if(product is null) return NotFound();
            List<BasketVM> basketDatas;

            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketDatas = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }
            else
            {
                basketDatas = new List<BasketVM>();
            }
            basketDatas.Add(new BasketVM
            {
                Id = (int)id,
                Price = product.Price,
                Count = 1

            });

            _accessor.HttpContext.Response.Cookies.Append("basket",JsonConvert.SerializeObject(basketDatas));
       
            return RedirectToAction(nameof(Index));
        }
        
    } 
}
