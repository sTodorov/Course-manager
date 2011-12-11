using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThisMember.Core;
using CouresManager.Core;
using CourseManager.Core;
using CourseManager.UI.Models;
using CourseManager.Core.DataAccess;

namespace CourseManager.UI.Controllers
{
  public class GroupController : BaseController
  {
    public ActionResult Index()
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Group, GroupModel>();

      var ctx = new CourseContext();

      var result = memberMapper.Map<List<Group>, List<GroupModel>>(ctx.Groups.ToList());

      return View(result);
    }

    //
    // GET: /Group/Create

    public ActionResult Create()
    {
      return View();
    }

    //
    // POST: /Group/Create

    [HttpPost]
    public ActionResult Create(GroupModel model)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<GroupModel, Group>();

      var ctx = new CourseContext();

      ctx.Groups.Add(memberMapper.Map<GroupModel, Group>(model));
      ctx.SaveChanges();

      return RedirectToAction("Index");
    }

    //
    // GET: /Group/Edit/5

    public ActionResult Edit(int id)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Group, GroupModel>();

      var ctx = new CourseContext();

      var result = memberMapper.Map<Group, GroupModel>(ctx.Groups.FirstOrDefault(c => c.ID == id));

      return View(result);
    }

    //
    // POST: /Group/Edit/5

    [HttpPost]
    public ActionResult Edit(int id, GroupModel model)
    {
      CourseContext ctx = new CourseContext();
      var group = ctx.Groups.FirstOrDefault(c => c.ID == model.ID);

      group.Name = model.Name;
      group.Identifier = model.Identifier;

      ctx.SaveChanges();

      return RedirectToAction("Index");
    }

    //
    // GET: /Group/Delete/5

    public ActionResult Delete(int id)
    {
      var memberMapper = new MemberMapper();
      memberMapper.CreateMap<Group, GroupModel>();

      var ctx = new CourseContext();

      var result = memberMapper.Map<Group, GroupModel>(ctx.Groups.FirstOrDefault(c => c.ID == id));

      return View(result);

    }

    //
    // POST: /Group/Delete/5

    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection)
    {
      var ctx = new CourseContext();

      ctx.Groups.Remove(ctx.Groups.FirstOrDefault(c => c.ID == id));
      ctx.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
