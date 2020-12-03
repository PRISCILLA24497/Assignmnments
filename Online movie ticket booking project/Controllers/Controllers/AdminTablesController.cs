using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Admin.Context;

namespace Admin.Controllers
{
    public class AdminTablesController : Controller
    {
        private MovieEntities db = new MovieEntities();

        // GET: AdminTables
        public ActionResult Index()
        {
            return View(db.AdminTables.ToList());
        }

        // GET: AdminTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminTable adminTable = db.AdminTables.Find(id);
            if (adminTable == null)
            {
                return HttpNotFound();
            }
            return View(adminTable);
        }

        // GET: AdminTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Admin_ID,Admin_Name,Admin_Password,DateOfBirth,Admin_Contact")] AdminTable adminTable)
        {
            if (ModelState.IsValid)
            {
                db.AdminTables.Add(adminTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adminTable);
        }

        // GET: AdminTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminTable adminTable = db.AdminTables.Find(id);
            if (adminTable == null)
            {
                return HttpNotFound();
            }
            return View(adminTable);
        }

        // POST: AdminTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Admin_ID,Admin_Name,Admin_Password,DateOfBirth,Admin_Contact")] AdminTable adminTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminTable);
        }

        // GET: AdminTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminTable adminTable = db.AdminTables.Find(id);
            if (adminTable == null)
            {
                return HttpNotFound();
            }
            return View(adminTable);
        }

        // POST: AdminTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdminTable adminTable = db.AdminTables.Find(id);
            db.AdminTables.Remove(adminTable);
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
