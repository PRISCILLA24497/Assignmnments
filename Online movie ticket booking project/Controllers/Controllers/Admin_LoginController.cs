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
    public class Admin_LoginController : Controller
    {
        private MovieEntities2 db = new MovieEntities2();

        // GET: Admin_Login
        public ActionResult Index()
        {
            return View(db.Admin_Login.ToList());
        }

        // GET: Admin_Login/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_Login admin_Login = db.Admin_Login.Find(id);
            if (admin_Login == null)
            {
                return HttpNotFound();
            }
            return View(admin_Login);
        }

        // GET: Admin_Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin_Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Admin_ID,Admin_Name,Admin_Password")] Admin_Login admin_Login)
        {
            if (ModelState.IsValid)
            {
                db.Admin_Login.Add(admin_Login);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admin_Login);
        }

        // GET: Admin_Login/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_Login admin_Login = db.Admin_Login.Find(id);
            if (admin_Login == null)
            {
                return HttpNotFound();
            }
            return View(admin_Login);
        }

        // POST: Admin_Login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Admin_ID,Admin_Name,Admin_Password")] Admin_Login admin_Login)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin_Login).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin_Login);
        }

        // GET: Admin_Login/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_Login admin_Login = db.Admin_Login.Find(id);
            if (admin_Login == null)
            {
                return HttpNotFound();
            }
            return View(admin_Login);
        }

        // POST: Admin_Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin_Login admin_Login = db.Admin_Login.Find(id);
            db.Admin_Login.Remove(admin_Login);
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
