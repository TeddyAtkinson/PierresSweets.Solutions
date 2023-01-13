using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Description { get; set; }
    public virtual List<FlavorTreat> JoinEntities { get; set; }
  }
}