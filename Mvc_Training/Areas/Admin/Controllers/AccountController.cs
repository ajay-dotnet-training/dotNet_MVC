using Mvc_Training.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc_Training.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        public ActionResult Index()
        {
            return View();
        }

        // POST : Admin/Account 
        [HttpPost]
        public ActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                if(model.UserName == "ajay" && model.Password == "ajay")
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index","Seller");
                }
            }
            return View();
        }

    }
}