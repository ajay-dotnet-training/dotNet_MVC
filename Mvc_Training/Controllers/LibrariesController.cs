using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mvc_Training.Models;

namespace Mvc_Training.Controllers
{
    [RoutePrefix("Book")]
    public class LibrariesController : Controller
    {
        private ASPNETDBEntities db = new ASPNETDBEntities();

        // GET: Libraries
        [Route("GetAll")]
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Libraries.ToList());
        }

        // GET: Libraries/Details/5
        [Route("GetID/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Library library = db.Libraries.Find(id);
            if (library == null)
            {
                return HttpNotFound();
            }
            return View(library);
        }

        // GET: Libraries/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libraries/Create
        [Route("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookId,Title,Author,Genre,PublishYear")] Library library)
        {
            if (ModelState.IsValid)
            {
                db.Libraries.Add(library);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(library);
        }

        // GET: Libraries/Edit/5
        [Route("Edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Library library = db.Libraries.Find(id);
            if (library == null)
            {
                return HttpNotFound();
            }
            return View(library);
        }

        // PUT: Libraries/Edit/5
        [Route("Edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookId,Title,Author,Genre,PublishYear")] Library library)
        {
            if (ModelState.IsValid)
            {
                db.Entry(library).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(library);
        }

        // GET: Libraries/Delete/5
        [Route("Delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Library library = db.Libraries.Find(id);
            if (library == null)
            {
                return HttpNotFound();
            }
            return View(library);
        }

        // POST: Libraries/Delete/5
         [HttpPost, ActionName("Delete")]
       // [HttpDelete]
        [Route("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Library library = db.Libraries.Find(id);
            db.Libraries.Remove(library);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
