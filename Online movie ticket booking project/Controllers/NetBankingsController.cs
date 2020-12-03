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
    public class NetBankingsController : Controller
    {
        private OnlineMovieTicketEntities14 db = new OnlineMovieTicketEntities14();

        // GET: NetBankings
        public ActionResult Index()
        {
            return View(db.NetBankings.ToList());
        }

        // GET: NetBankings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NetBanking netBanking = db.NetBankings.Find(id);
            if (netBanking == null)
            {
                return HttpNotFound();
            }
            return View(netBanking);
        }

        // GET: NetBankings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NetBankings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Netbankingid,CardNumber,Name,CVV")] NetBanking netBanking)
        {
            if (ModelState.IsValid)
            {
                db.NetBankings.Add(netBanking);
                db.SaveChanges();

               
            }
            ViewBag.Message = "Payment Successful";
            return View(netBanking);
        }

        // GET: NetBankings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NetBanking netBanking = db.NetBankings.Find(id);
            if (netBanking == null)
            {
                return HttpNotFound();
            }
            return View(netBanking);
        }

        // POST: NetBankings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Netbankingid,CardNumber,Name,CVV")] NetBanking netBanking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(netBanking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(netBanking);
        }

        // GET: NetBankings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NetBanking netBanking = db.NetBankings.Find(id);
            if (netBanking == null)
            {
                return HttpNotFound();
            }
            return View(netBanking);
        }

        // POST: NetBankings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NetBanking netBanking = db.NetBankings.Find(id);
            db.NetBankings.Remove(netBanking);
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
