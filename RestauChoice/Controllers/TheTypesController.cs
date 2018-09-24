using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RestauChoice.Models;

namespace RestauChoice.Controllers
{
    public class TheTypesController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: TheTypes
        public ActionResult Index()
        {
            return View(db.Types.ToList());
        }

        // GET: TheTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheType theType = db.Types.Find(id);
            if (theType == null)
            {
                return HttpNotFound();
            }
            return View(theType);
        }

        // GET: TheTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TheTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TheTypeId,Nom")] TheType theType)
        {
            if (ModelState.IsValid)
            {
                db.Types.Add(theType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(theType);
        }

        // GET: TheTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheType theType = db.Types.Find(id);
            if (theType == null)
            {
                return HttpNotFound();
            }
            return View(theType);
        }

        // POST: TheTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TheTypeId,Nom")] TheType theType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(theType);
        }

        // GET: TheTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheType theType = db.Types.Find(id);
            if (theType == null)
            {
                return HttpNotFound();
            }
            return View(theType);
        }

        // POST: TheTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TheType theType = db.Types.Find(id);
            db.Types.Remove(theType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
