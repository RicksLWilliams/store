using System.ComponentModel.DataAnnotations;

namespace store.Models
{
  public class Shoe
  {
    public int Id { get; set; }
    [Required]
    [MaxLength(80)]
    public string Title { get; set; }
    public string Details { get; set; }
    public string Style { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public int Supply  { get; set; }
  }
}