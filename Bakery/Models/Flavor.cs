using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }

    [Required(ErrorMessage = "Please enter a flavor name.")]
    public string FlavorName { get; set; }

    [Required(ErrorMessage = "Please enter a description of the flavor.")]
    public string FlavorDescription { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
  }
}