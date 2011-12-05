using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouresManager.Core
{
  public class SemesterType
  {
    public int ID { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public virtual ICollection<SemesterTypeName> SemesterTypeNames { get; set; }
  }
}
