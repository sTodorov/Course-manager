using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CouresManager.Core
{
  public class SemesterTypeName
  {
    [Key()]
    public int SemesterTypeID { get; set; }

    [Key()]
    public int LanguageID { get; set; }

    public string Name { get; set; }

    public virtual Language Language { get; set; }

    public virtual SemesterType SemesterType { get; set; }
  }
}
