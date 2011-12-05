using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CouresManager.Core
{
  public class SemesterName
  {
    public int LanguageID { get; set; }

    public int SemesterID { get; set; }

    public string Name { get; set; }

    public virtual Semester Semester { get; set; }

    public virtual Language Language { get; set; }
  }
}
