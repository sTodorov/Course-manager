using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouresManager.Core
{
  public class Semester
  {
    public int ID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Name { get; set; }
  }
}
