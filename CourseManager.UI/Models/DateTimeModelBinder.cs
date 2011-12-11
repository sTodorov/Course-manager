using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace CourseManager.UI.Models
{
  public class DateTimeModelBinder : IModelBinder
  {
    #region IModelBinder Members

    public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    {

      if (bindingContext == null)
        throw new ArgumentNullException("bindingContext");

      string dateTimeString = controllerContext.RequestContext.HttpContext.Request[bindingContext.ModelName].ToString();

      //try parse in our

      if (string.IsNullOrEmpty(dateTimeString))
        throw new InvalidOperationException();
      //dateTimeString.ThrowIf(c => string.IsNullOrEmpty(c), message: string.Format("{0} cannot be null", bindingContext.ModelName));
      DateTime datetime;

      if (!DateTime.TryParseExact(dateTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out datetime))
      {
        bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Date was not in the correct format. e.g. 31/12/2011");
      }

      return datetime;
    }
    #endregion
  }
}