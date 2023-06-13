using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public int? MachineId { get; set; }
    public Machine Machine { get; set; }
    public List<EngineerTag> JoinEntities { get; }
    public List<EngineerMachine> EngineerMachines { get; set; }
  }
}