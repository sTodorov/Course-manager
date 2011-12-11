using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Core.DataAccess;
using CourseManager.UI.Models;
using ThisMember.Core;
using CouresManager.Core;
using System.Threading;
using System.Globalization;
using ThisMember.Core.Interfaces;

namespace CourseManager.UI.Controllers
{
  public class TeacherController : BaseController
  {
    public ActionResult Index()
    {

      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Teacher, TeacherModel>(source => new TeacherModel()
      {
        RoomNr = source.RoomNumber,
        SchoolPhone = source.Phone,
        Identifier = source.IDNumber
      });

      var ctx = new CourseContext();

      var result = memberMapper.Map<List<Teacher>, List<TeacherModel>>(ctx.Teachers.ToList());


      return View(result);
    }

    public ActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Add(TeacherModel model)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<TeacherModel, Teacher>(source =>
        new Teacher()
        {
          Phone = source.SchoolPhone,
          IDNumber = source.Identifier,
          RoomNumber = source.RoomNr
        });

      CourseContext ctx = new CourseContext();
      ctx.Teachers.Add(memberMapper.Map<Teacher>(model));
      ctx.SaveChanges();

      return RedirectToAction("Index");
    }


    public ActionResult Update(int id)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Teacher, TeacherModel>(source => new TeacherModel()
      {
        RoomNr = source.RoomNumber,
        SchoolPhone = source.Phone,
        Identifier = source.IDNumber
      });

      var ctx = new CourseContext();

      var result = memberMapper.Map<Teacher, TeacherModel>(ctx.Teachers.FirstOrDefault(c => c.ID == id));

      return View(result);
    }

    [HttpPost]
    public ActionResult Update(TeacherModel model)
    {

      CourseContext ctx = new CourseContext();
      var teacher = ctx.Teachers.FirstOrDefault(c => c.ID == model.ID);

      teacher.FirstName = model.FirstName;
      teacher.LastName = model.LastName;
      teacher.Email = model.Email;
      teacher.RoomNumber = model.RoomNr;
      teacher.Phone = model.SchoolPhone;

      ctx.SaveChanges();

      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Teacher, TeacherModel>(source => new TeacherModel()
      {
        RoomNr = source.RoomNumber,
        SchoolPhone = source.Phone,
        Identifier = source.IDNumber
      });

      var ctx = new CourseContext();

      var result = memberMapper.Map<Teacher, TeacherModel>(ctx.Teachers.FirstOrDefault(c => c.ID == id));
      return View(result);
    }

    public ActionResult Delete(int id)
    {
      CourseContext ctx = new CourseContext();

      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Teacher, TeacherModel>(source => new TeacherModel()
      {
        RoomNr = source.RoomNumber,
        SchoolPhone = source.Phone,
        Identifier = source.IDNumber
      });



      var result = memberMapper.Map<Teacher, TeacherModel>(ctx.Teachers.FirstOrDefault(c => c.ID == id));
      return View(result);
    }

    [HttpPost]
    public ActionResult Delete(TeacherModel model)
    {
      CourseContext ctx = new CourseContext();
      ctx.Teachers.Remove(ctx.Teachers.FirstOrDefault(c => c.ID == model.ID));

      return View();
    }
  }
}
