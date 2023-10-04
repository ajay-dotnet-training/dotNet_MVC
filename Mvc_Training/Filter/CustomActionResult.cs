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
          //Debug.WriteLine("Hello From CustomAction Filter OnActionExecuted");
            filterContext.Controller.ViewBag.ActionMessage = "OnActionExecuted of CustomActionResult Filter Included in Admin Area For Seller Controller ";
            
            // Code to be executed after the action method has been called
            //string controllerName = filterContext.RouteData.Values["controller"].ToString();
            //string actionName = filterContext.RouteData.Values["action"].ToString();
            //string logMessage = $"Executed action {actionName} in controller {controllerName} at {DateTime.Now}";
            //Console.WriteLine(logMessage);

            base.OnActionExecuted(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Code to be executed before the action method is called
            //string controllerName = filterContext.RouteData.Values["controller"].ToString();
            //string actionName = filterContext.RouteData.Values["action"].ToString();
            //string logMessage = $"Executing action {actionName} in controller {controllerName} at {DateTime.Now}";
            //Console.WriteLine(logMessage);

            // You can also log to a file, database, or any other desired location
            base.OnActionExecuting(filterContext);
           // Debug.WriteLine("Hello From CustomAction Filter OnActionExecuting");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
          //  Debug.WriteLine("Hello From CustomAction Filter OnResultExecuted");
            filterContext.Controller.ViewBag.ResultMessage = "\n OnResultExecuted on CustomActionResult Filter Included in Admin Area ";
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("Hello From CustomAction Filter OnActionExecuted");
        }

    }
}