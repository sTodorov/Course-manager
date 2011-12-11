using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThisMember.Core;
using CouresManager.Core;
using CourseManager.UI.Models;
using CourseManager.Core.DataAccess;

namespace CourseManager.UI.Controllers
{
  public class SemesterController : BaseController
  {
    public ActionResult Index()
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Semester, SemesterModel>();

      var ctx = new CourseContext();

      var result = memberMapper.Map<List<Semester>, List<SemesterModel>>(ctx.Semesters.ToList());

      return View(result);
    }


    public ActionResult Create()
    {
      return View();
    }


    public ActionResult Edit(int id)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Semester, SemesterModel>();

      var ctx = new CourseContext();

      var result = memberMapper.Map<Semester, SemesterModel>(ctx.Semesters.FirstOrDefault(c => c.ID == id));

      return View(result);

    }

    [HttpPost]
    public ActionResult Edit(SemesterModel model)
    {
      CourseContext ctx = new CourseContext();
      var semester = ctx.Semesters.FirstOrDefault(c => c.ID == model.ID);

      semester.Name = model.Name;
      semester.StartDate = model.StartDate;
      semester.EndDate = model.EndDate;

      ctx.SaveChanges();

      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult Create(SemesterModel model)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<SemesterModel, Semester>();

      var ctx = new CourseContext();

      ctx.Semesters.Add(memberMapper.Map<SemesterModel, Semester>(model));
      ctx.SaveChanges();

      return RedirectToAction("Index");

    }

    public ActionResult Delete(int id)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Semester, SemesterModel>();

      var ctx = new CourseContext();

      var result = memberMapper.Map<Semester, SemesterModel>(ctx.Semesters.FirstOrDefault(c => c.ID == id));

      return View(result);
    }

    //
    // POST: /Semester/Delete/5

    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection)
    {
      var ctx = new CourseContext();

      ctx.Semesters.Remove(ctx.Semesters.FirstOrDefault(c => c.ID == id));
      ctx.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
