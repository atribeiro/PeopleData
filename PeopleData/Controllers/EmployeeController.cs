using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopleData.Models;

namespace PeopleData.Controllers
{
    public class EmployeeController : Controller
    {
        private EmplSampleEntities db = new EmplSampleEntities();

        //
        // GET: /PeopleDetail/

        public ActionResult Index()
        {
            return View(db.PersonDetails.ToList());
        }

        //
        // GET: /PeopleDetail/Details/5

        public ActionResult Details(int id = 0)
        {
            PersonDetail persondetail = db.PersonDetails.Find(id);
            if (persondetail == null)
            {
                return HttpNotFound();
            }
            return View(persondetail);
        }

        //
        // GET: /PeopleDetail/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PeopleDetail/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonDetail persondetail)
        {
            if (ModelState.IsValid)
            {
                db.PersonDetails.Add(persondetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(persondetail);
        }

        //
        // GET: /PeopleDetail/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PersonDetail persondetail = db.PersonDetails.Find(id);
            if (persondetail == null)
            {
                return HttpNotFound();
            }
            return View(persondetail);
        }

        //
        // POST: /PeopleDetail/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonDetail persondetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persondetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(persondetail);
        }

        //
        // GET: /PeopleDetail/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PersonDetail persondetail = db.PersonDetails.Find(id);
            if (persondetail == null)
            {
                return HttpNotFound();
            }
            return View(persondetail);
        }

        //
        // POST: /PeopleDetail/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonDetail persondetail = db.PersonDetails.Find(id);
            db.PersonDetails.Remove(persondetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}