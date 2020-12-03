using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieTicketBooking.Models;

namespace OnlineMovieTicketBooking.Controllers
{
    public class UPIsController : Controller
    {
        private OnlineMovieTicketEntities14 db = new OnlineMovieTicketEntities14();

        // GET: UPIs
        public ActionResult Index()
        {
            return View(db.UPIs.ToList());
        }

        // GET: UPIs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UPI uPI = db.UPIs.Find(id);
            if (uPI == null)
            {
                return HttpNotFound();
            }
            return View(uPI);
        }

        // GET: UPIs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UPIs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "num,UPIId,UPIPIN,Name")] UPI uPI)
        {
            if (ModelState.IsValid)
            {
                db.UPIs.Add(uPI);
                db.SaveChanges();
               
            }

            return View(uPI);
        }

        // GET: UPIs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UPI uPI = db.UPIs.Find(id);
            if (uPI == null)
            {
                return HttpNotFound();
            }
            return View(uPI);
        }

        // POST: UPIs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "num,UPIId,UPIPIN,Name")] UPI uPI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uPI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uPI);
        }

        // GET: UPIs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UPI uPI = db.UPIs.Find(id);
            if (uPI == null)
            {
                return HttpNotFound();
            }
            return View(uPI);
        }

        // POST: UPIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UPI uPI = db.UPIs.Find(id);
            db.UPIs.Remove(uPI);
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
