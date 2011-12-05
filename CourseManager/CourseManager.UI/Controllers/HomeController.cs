using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Core.DataAccess;

namespace CourseManager.UI.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Message = "Welcome to ASP.NET MVC!";

      CourseContext ctx = new CourseContext();

      return View();
    }

    public ActionResult About()
    {
      return View();
    }
  }
}
