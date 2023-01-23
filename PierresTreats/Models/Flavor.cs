using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The Flavor description field cannot be empty!")]
    public string Description { get; set; }
    public virtual List<FlavorTreat> JoinEntities { get; set; }
  }
}