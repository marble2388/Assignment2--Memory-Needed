using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class ParentTablesController : Controller
    {
        private ParentThing db = new ParentThing();

        // GET: ParentTables
        public ActionResult Index()
        {
            return View(db.ParentTables.ToList());
        }

        // GET: ParentTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentTable parentTable = db.ParentTables.Find(id);
            if (parentTable == null)
            {
                return HttpNotFound();
            }
            return View(parentTable);
        }

        // GET: ParentTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParentTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,otherthing1,otherthing2,otherthing3")] ParentTable parentTable)
        {
            if (ModelState.IsValid)
            {
                db.ParentTables.Add(parentTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parentTable);
        }

        // GET: ParentTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentTable parentTable = db.ParentTables.Find(id);
            if (parentTable == null)
            {
                return HttpNotFound();
            }
            return View(parentTable);
        }

        // POST: ParentTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,otherthing1,otherthing2,otherthing3")] ParentTable parentTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parentTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parentTable);
        }

        // GET: ParentTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentTable parentTable = db.ParentTables.Find(id);
            if (parentTable == null)
            {
                return HttpNotFound();
            }
            return View(parentTable);
        }

        // POST: ParentTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParentTable parentTable = db.ParentTables.Find(id);
            db.ParentTables.Remove(parentTable);
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
