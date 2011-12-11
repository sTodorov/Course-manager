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

    [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Teacher_LastName_Error")]
    [Display(ResourceType = typeof(Resources), Name = "Teacher_LastName_Label")]
    public string LastName { get; set; }

    [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Teacher_Email_Error")]
    [Display(ResourceType = typeof(Resources), Name = "Teacher_Email_Label")]
    [Email(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Teacher_EmailNotValid_Error")]
    public string Email { get; set; }

    [Display(ResourceType = typeof(Resources), Name = "Teacher_Office_Label")]
    public string RoomNr { get; set; }

    [Display(ResourceType = typeof(Resources), Name = "Teacher_PhoneNumber_Label")]
    public string SchoolPhone { get; set; }

    [Display(ResourceType = typeof(Resources), Name = "Teacher_Identifier_Label")]
    public string Identifier { get; set; }

    [Display(ResourceType = typeof(Resources), Name = "Teacher_Department_Label")]
    public string Department { get; set; }

    public int ID { get; set; }
  }
}
