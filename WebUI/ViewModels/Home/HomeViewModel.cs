using Core.Entities;

namespace WebUI.ViewModels.Home;

public class HomeViewModel
{
    public IEnumerable<SliderBackround> SliderBackrounds { get; set; } = null!;
    public IEnumerable<SliderText> SliderText { get; set; } = null!;
}
