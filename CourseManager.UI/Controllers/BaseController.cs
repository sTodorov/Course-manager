using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Globalization;
using System.Threading;
using System.Web;

namespace CourseManager.UI.Controllers
{
  public class BaseController : Controller
  {
    protected const string defaultLanguage = "bg";

    protected override void ExecuteCore()
    {
      if (Request["contentLanguage"] != null && !string.IsNullOrWhiteSpace(Request["contentLanguage"].ToString()))
      {
        // set the culture from the route data (url)
        var lang = Request["contentLanguage"].ToString();
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(lang);
      }
      else
      {
        SetLanguageCookie();
      }
      base.ExecuteCore();
    }

    protected void SetLanguageCookie(string language = "")
    {
      //indicate no lang has been passed
      ViewData["NoContentLanguage"] = true;
      // load the culture info from the cookie
      var cookie = HttpContext.Request.Cookies["CurrentUICulture"];
      var langHeader = string.Empty;

      if (cookie != null)
      {
        // set the culture by the cookie content
        if (!string.IsNullOrEmpty(language))
        {
          langHeader = language;
          cookie.Value = language;
        }
        else
        {
          langHeader = cookie.Value;
        }
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(langHeader);
      }
      else
      {
        if (string.IsNullOrEmpty(language))
        {
          langHeader = defaultLanguage; //use this default
        }
        else
        {
          langHeader = defaultLanguage;
        }
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(langHeader);
      }
      // set the lang value into route data
      RouteData.Values["contentLanguage"] = langHeader;
      ViewData["SelectedLanguage"] = langHeader.Contains('-') ? langHeader.Substring(0, langHeader.IndexOf('-')) : langHeader;

      // save the location into cookie
      HttpCookie _cookie = new HttpCookie("CurrentUICulture", Thread.CurrentThread.CurrentUICulture.Name);
      _cookie.Expires = DateTime.Now.AddYears(1);
      HttpContext.Response.SetCookie(_cookie);
    }
  }
}
