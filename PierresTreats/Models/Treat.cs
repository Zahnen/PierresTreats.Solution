using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Modifications { get; set; }
    public string Notes{ get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<TreatFlavor> Flavors { get; set; }
  }
}