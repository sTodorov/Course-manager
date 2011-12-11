using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Core.DataAccess;
using System.Threading;
using System.Globalization;

namespace CourseManager.UI.Controllers
{
  public class HomeController : BaseController
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      return View();
    }
  }
}
