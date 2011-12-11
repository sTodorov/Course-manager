using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CouresManager.Core
{
  public class Teacher
  {

    public int ID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string IDNumber { get; set; }

    public string RoomNumber { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public string Department { get; set; }
  }
}
