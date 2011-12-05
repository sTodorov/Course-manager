using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouresManager.Core
{
  public class Semester
  {
    public int ID { get; set; }

    public int SemesterTypeID { get; set; }

    public virtual SemesterType SemesterType { get; set; }

    public virtual ICollection<SemesterName> SemesterNames { get; set; }
  }
}
