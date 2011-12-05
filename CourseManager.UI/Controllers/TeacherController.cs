using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Core.DataAccess;
using CourseManager.UI.Models;
using ThisMember.Core;
using CouresManager.Core;

namespace CourseManager.UI.Controllers
{
  public class TeacherController : Controller
  {
    public ActionResult Index()
    {

      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Teacher, TeacherModel>(source => new TeacherModel()
      {
        RoomNr = source.RoomNumber,
        SchoolPhone = source.Phone,
        Email = source.Email,
        FirstName = source.FirstName,
        LastName = source.LastName
      });

      var ctx = new CourseContext();

      var result = memberMapper.Map<List<Teacher>, List<TeacherModel>>(ctx.Teachers.ToList());


      return View(result);
    }

    public ActionResult Create(TeacherModel model)
    {
      return View();
    }

  }
}
