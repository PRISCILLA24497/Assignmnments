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
    public class SeatType1Controller : Controller
    {
        private OnlineMovieTicketEntities31 db = new OnlineMovieTicketEntities31();

        // GET: SeatType1
        public ActionResult Index()
        {
            return View(db.SeatType1.ToList());
        }

        // GET: SeatType1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SeatType1 seatType1 = db.SeatType1.Find(id);
            if (seatType1 == null)
            {
                return HttpNotFound();
            }
            return View(seatType1);
        }

        // GET: SeatType1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SeatType1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,type,Persons,Price")] SeatType1 seatType1)
        {
            if (ModelState.IsValid)
            {
                db.SeatType1.Add(seatType1);
                db.SaveChanges();
                return RedirectToAction("Welcome");
            }

            return View(seatType1);
        }

        // GET: SeatType1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SeatType1 seatType1 = db.SeatType1.Find(id);
            if (seatType1 == null)
            {
                return HttpNotFound();
            }
            return View(seatType1);
        }

        // POST: SeatType1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,type,Persons,Price")] SeatType1 seatType1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seatType1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(seatType1);
        }

        // GET: SeatType1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SeatType1 seatType1 = db.SeatType1.Find(id);
            if (seatType1 == null)
            {
                return HttpNotFound();
            }
            return View(seatType1);
        }

        // POST: SeatType1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SeatType1 seatType1 = db.SeatType1.Find(id);
            db.SeatType1.Remove(seatType1);
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

        public ActionResult Welcome()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Welcome(SeatType1 seat)
        {
            using (OnlineMovieTicketEntities31 db = new OnlineMovieTicketEntities31())
            {
                db.SeatType1.Add(seat);
                db.SaveChanges();

                int SeatId = seat.id;
                string Type = seat.type;
                var Tickets = seat.Persons;
                var Price = seat.Price;


                ViewBag.SeatId = SeatId;
                ViewBag.Type = Type;
                ViewBag.Tickets = Tickets;
                ViewBag.Price = Price;

               
            }

            return View();


        }

    }
}