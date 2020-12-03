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
    public class ShowsController : Controller
    {
        private KeysEntities db = new KeysEntities();

        // GET: Shows
        public ActionResult Index()
        {
            var shows = db.Shows.Include(s => s.Movie).Include(s => s.Screen).Include(s => s.Seat).Include(s => s.Theatre);
            return View(shows.ToList());
        }

        // GET: Shows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = db.Shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // GET: Shows/Create
        public ActionResult Add_Show()
        {
            ViewBag.MovieName = new SelectList(db.Movies, "Movie_ID", "Movie_Name");
            ViewBag.ScreenID = new SelectList(db.Screens, "Screen_ID", "ScreenName");
            ViewBag.Seat_ID = new SelectList(db.Seats, "SeatID", "Ticket");
            ViewBag.TheatreID = new SelectList(db.Theatres, "Theatre_ID", "Theatre_Name");
            return View();
        }

        // POST: Shows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add_Show([Bind(Include = "Show_ID,ShowStartTime,ShowEndTime,Seat_ID,ShowName,TheatreID,MovieName,ScreenID")] Show show)
        {
            if (ModelState.IsValid)
            {
                db.Shows.Add(show);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieName = new SelectList(db.Movies, "Movie_ID", "Movie_Name", show.MovieName);
            ViewBag.ScreenID = new SelectList(db.Screens, "Screen_ID", "ScreenName", show.ScreenID);
            ViewBag.Seat_ID = new SelectList(db.Seats, "SeatID", "Ticket", show.Seat_ID);
            ViewBag.TheatreID = new SelectList(db.Theatres, "Theatre_ID", "Theatre_Name", show.TheatreID);
            return View(show);
        }

        // GET: Shows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = db.Shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieName = new SelectList(db.Movies, "Movie_ID", "Movie_Name", show.MovieName);
            ViewBag.ScreenID = new SelectList(db.Screens, "Screen_ID", "ScreenName", show.ScreenID);
            ViewBag.Seat_ID = new SelectList(db.Seats, "SeatID", "Ticket", show.Seat_ID);
            ViewBag.TheatreID = new SelectList(db.Theatres, "Theatre_ID", "Theatre_Name", show.TheatreID);
            return View(show);
        }

        // POST: Shows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Show_ID,ShowStartTime,ShowEndTime,Seat_ID,ShowName,TheatreID,MovieName,ScreenID")] Show show)
        {
            if (ModelState.IsValid)
            {
                db.Entry(show).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieName = new SelectList(db.Movies, "Movie_ID", "Movie_Name", show.MovieName);
            ViewBag.ScreenID = new SelectList(db.Screens, "Screen_ID", "ScreenName", show.ScreenID);
            ViewBag.Seat_ID = new SelectList(db.Seats, "SeatID", "Ticket", show.Seat_ID);
            ViewBag.TheatreID = new SelectList(db.Theatres, "Theatre_ID", "Theatre_Name", show.TheatreID);
            return View(show);
        }

        // GET: Shows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = db.Shows.Find(id);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // POST: Shows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Show show = db.Shows.Find(id);
            db.Shows.Remove(show);
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
