using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CourseManager.UI.Models
{
  public class TeacherModel
  {
    [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Teacher_FirstName_Error")]
    [Display(ResourceType = typeof(Resources), Name = "Teacher_FirstName_Label")]
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string RoomNr { get; set; }

    public string SchoolPhone { get; set; }
  }
}
