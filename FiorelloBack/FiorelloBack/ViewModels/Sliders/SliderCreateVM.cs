using System.ComponentModel.DataAnnotations;

namespace FiorelloBack.ViewModels.Sliders
{
    public class SliderCreateVM
    {
        [Required]
        public List<IFormFile> Images { get; set; }
    }
}
