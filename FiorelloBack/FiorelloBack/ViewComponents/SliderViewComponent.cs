using FiorelloBack.Models;
using FiorelloBack.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloBack.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderService _sliderService;
        public SliderViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = new SliderVMVC
            {
                Sliders = await _sliderService.GetAllAsync(),
                SliderInfo = await _sliderService.GetSliderInfoAsync(),
            };

            return await Task.FromResult(View(data));
        }
    }
}


public class SliderVMVC
{
    public IEnumerable<Slider> Sliders { get; set; }
    public SliderInfo SliderInfo { get; set; }
}
