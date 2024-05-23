using FiorelloBack.Services;
using FiorelloBack.Services.Interfaces;
using FiorelloBack.ViewModels.Baskets;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FiorelloBack.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ISettingService _settingService;
        private readonly IHttpContextAccessor _accessor;
        public HeaderViewComponent(ISettingService settingService,
                                    IHttpContextAccessor accessor)
        {
            _settingService = settingService;
            _accessor = accessor;

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<BasketVM> basketDatas = new();

            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketDatas = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }         

            Dictionary<string, string> settings = await _settingService.GetAllAsync();

            HeaderVm response = new()
            {
                Settings = settings,
                BasketCount = basketDatas.Sum(m => m.Count),
                BasketTotalPrice = basketDatas.Sum(m => m.Count * m.Price)
            };
            
            return await Task.FromResult(View(response));    

        }
    }
}

public class HeaderVm
{
    public int BasketCount { get; set; }
    public decimal BasketTotalPrice { get; set; }
    public Dictionary<string, string> Settings { get; set; }
}