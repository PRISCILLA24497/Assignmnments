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
    public class ticketnewsController : Controller
    {
        private OnlineMovieTicketEntities32 db = new OnlineMovieTicketEntities32();

        // GET: ticketnews
        public ActionResult Index()
        {
            var ticketnew = db.ticketnew.Include(t => t.Movienew).Include(t => t.SeatType1).Include(t => t.Shownew).Include(t => t.Theatrenew);
            return View(ticketnew.ToList());
        }

        // GET: ticketnews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ticketnew ticketnew = db.ticketnew.Find(id);
            if (ticketnew == null)
            {
                return HttpNotFound();
            }
            return View(ticketnew);
        }

        // GET: ticketnews/Create
        public ActionResult Create()
        {
            ViewBag.Movieid = new SelectList(db.Movienew, "Mid", "mname");
            ViewBag.seatid = new SelectList(db.SeatType1, "id", "type");
            ViewBag.Showid = new SelectList(db.Shownew, "sid", "showname");
            ViewBag.Theatreid = new SelectList(db.Theatrenew, "tid", "tname");
            return View();
        }

        // POST: ticketnews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Tid,seatid,Movieid,Showid,Theatreid")] ticketnew ticketnew)
        {
            if (ModelState.IsValid)
            {
                db.ticketnew.Add(ticketnew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Movieid = new SelectList(db.Movienew, "Mid", "mname", ticketnew.Movieid);
            ViewBag.seatid = new SelectList(db.SeatType1, "id", "type", ticketnew.seatid);
            ViewBag.Showid = new SelectList(db.Shownew, "sid", "showname", ticketnew.Showid);
            ViewBag.Theatreid = new SelectList(db.Theatrenew, "tid", "tname", ticketnew.Theatreid);
            return View(ticketnew);
        }

        // GET: ticketnews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ticketnew ticketnew = db.ticketnew.Find(id);
            if (ticketnew == null)
            {
                return HttpNotFound();
            }
            ViewBag.Movieid = new SelectList(db.Movienew, "Mid", "mname", ticketnew.Movieid);
            ViewBag.seatid = new SelectList(db.SeatType1, "id", "type", ticketnew.seatid);
            ViewBag.Showid = new SelectList(db.Shownew, "sid", "showname", ticketnew.Showid);
            ViewBag.Theatreid = new SelectList(db.Theatrenew, "tid", "tname", ticketnew.Theatreid);
            return View(ticketnew);
        }

        // POST: ticketnews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Tid,seatid,Movieid,Showid,Theatreid")] ticketnew ticketnew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticketnew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Movieid = new SelectList(db.Movienew, "Mid", "mname", ticketnew.Movieid);
            ViewBag.seatid = new SelectList(db.SeatType1, "id", "type", ticketnew.seatid);
            ViewBag.Showid = new SelectList(db.Shownew, "sid", "showname", ticketnew.Showid);
            ViewBag.Theatreid = new SelectList(db.Theatrenew, "tid", "tname", ticketnew.Theatreid);
            return View(ticketnew);
        }

        // GET: ticketnews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ticketnew ticketnew = db.ticketnew.Find(id);
            if (ticketnew == null)
            {
                return HttpNotFound();
            }
            return View(ticketnew);
        }

        // POST: ticketnews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ticketnew ticketnew = db.ticketnew.Find(id);
            db.ticketnew.Remove(ticketnew);
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

        public ActionResult Search(int?search)
        {
            var model = db.ticketnew.Where(x => x.Tid == search).ToList();
            return View(model);
        }
    }
}
