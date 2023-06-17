using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "Please enter an Engineer name!")]
    public string EngineerName { get; set; }

    [Required(ErrorMessage = "Please enter details about the Engineer.")]
    public string EngineerDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}
