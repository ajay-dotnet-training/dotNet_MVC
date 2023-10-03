using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Training.Filter
{
    public class CustomActionResult : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Hello From CustomAction Filter OnActionExecuted");
            filterContext.Controller.ViewBag.Message = "CustomAction Filter Included in Area ";
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Hello From CustomAction Filter OnActionExecuting");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("Hello From CustomAction Filter OnResultExecuted");
            filterContext.Controller.ViewBag.Message = "CustomAction Filter Included in Area ";
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("Hello From CustomAction Filter OnActionExecuted");
            filterContext.Controller.ViewBag.Message = "CustomAction Filter Included in Area ";
        }

    }
}