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
    public class ChildTablesController : Controller
    {
        private ParentThing db = new ParentThing();

        // GET: ChildTables
        public ActionResult Index()
        {
            return View(db.ChildTables.ToList());
        }

        // GET: ChildTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChildTable childTable = db.ChildTables.Find(id);
            if (childTable == null)
            {
                return HttpNotFound();
            }
            return View(childTable);
        }

        // GET: ChildTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChildTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PID,thing1,thing2")] ChildTable childTable)
        {
            if (ModelState.IsValid)
            {
                db.ChildTables.Add(childTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(childTable);
        }

        // GET: ChildTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChildTable childTable = db.ChildTables.Find(id);
            if (childTable == null)
            {
                return HttpNotFound();
            }
            return View(childTable);
        }

        // POST: ChildTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PID,thing1,thing2")] ChildTable childTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(childTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(childTable);
        }

        // GET: ChildTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChildTable childTable = db.ChildTables.Find(id);
            if (childTable == null)
            {
                return HttpNotFound();
            }
            return View(childTable);
        }

        // POST: ChildTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChildTable childTable = db.ChildTables.Find(id);
            db.ChildTables.Remove(childTable);
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
