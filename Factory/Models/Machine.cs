using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public virtual ICollection<RepairLicense> RepairLicenses { get; set; }
  }
}