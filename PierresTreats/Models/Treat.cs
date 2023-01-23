using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The Treat name field cannot be empty!")]
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual List<FlavorTreat> JoinEntities { get; }
  }
}