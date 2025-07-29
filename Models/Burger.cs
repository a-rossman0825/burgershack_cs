
using System.ComponentModel.DataAnnotations;

namespace burgershack_cs.Models;

public class Burger
{
  public int Id { get; set; }
  [MinLength(2)] public string Name { get; set; }
  public decimal Price { get; set; }
  public string Toppings { get; set; }
  public bool IsLettuceWrap { get; set; }
  public string Sauce { get; set; }
  public string Description { get; set; }
}