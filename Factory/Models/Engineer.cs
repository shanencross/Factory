using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public DateTime EmploymentDate { get; set; }
    public virtual ICollection<RepairLicense> RepairLicenses { get; set; }
  }
}