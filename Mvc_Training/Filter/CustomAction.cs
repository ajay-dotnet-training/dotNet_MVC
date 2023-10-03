using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Training.Filter
{
    public class CustomAction : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Hello From CustomAction Filter OnActionExecuted");
            filterContext.Controller.ViewBag.Message = "CustomAction Filter Included in Area ";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Hello From CustomAction Filter OnActionExecuting");
        }
    }
}