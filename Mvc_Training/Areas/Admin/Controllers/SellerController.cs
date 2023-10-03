using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Training.Filter;

namespace Mvc_Training.Areas.Admin.Controllers
{
    public class SellerController : Controller
    {
        // GET: Admin/Seller
        [CustomAuthentication]
        [CustomAction]
        [CustomException]
        public ActionResult Index()
        {
            return View();
            // return View("Ajay's Exception Example");
        }
    }
}