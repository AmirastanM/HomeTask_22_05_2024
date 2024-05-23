using FiorelloBack.Models;

namespace FiorelloBack.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> GetAllAsync();

        public Task<SliderInfo> GetSliderInfoAsync();

    }
}
