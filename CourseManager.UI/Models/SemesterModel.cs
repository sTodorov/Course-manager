using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CourseManager.UI.Models
{
  public class SemesterModel
  {
    public int ID { get; set; }

    [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Semester_Name_Error")]
    [Display(ResourceType = typeof(Resources), Name = "Semester_Name_Label")]
    public string Name { get; set; }

    [UIHint("DateTime")]
    [Display(ResourceType = typeof(Resources), Name = "Semester_StartDate_Label")]
    public DateTime StartDate { get; set; }

    [UIHint("DateTime")]
    [Display(ResourceType = typeof(Resources), Name = "Semester_EndDate_Label")]
    public DateTime EndDate { get; set; }
  }
}