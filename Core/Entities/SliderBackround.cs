using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class SliderBackround
{

    public int Id { get; set; }
    [Required]
    public string? Image { get; set; }
}
