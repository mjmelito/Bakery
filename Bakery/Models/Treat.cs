using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }

    [Required(ErrorMessage = "Please enter a Treat name!")]
    public string TreatName { get; set; }

    [Required(ErrorMessage = "Please enter details about the Treat.")]
    public string TreatDetails { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}
