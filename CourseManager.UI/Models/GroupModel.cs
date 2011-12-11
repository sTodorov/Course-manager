using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CourseManager.UI.Models
{
  public class GroupModel
  {

    [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Group_Name_Error")]
    [Display(ResourceType = typeof(Resources), Name = "Group_Name_Label")]
    public string Name { get; set; }

    [Display(ResourceType = typeof(Resources), Name = "Group_Identifier_Label")]
    public string Identifier { get; set; }

    public int ID { get; set; }
  }
}