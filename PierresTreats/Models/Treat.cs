using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual List<FlavorTreat> JoinEntities { get; }
  }
}