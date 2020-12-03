using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieTicketBooking.Models;

namespace OnlineMovieTicketBooking.Controllers
{
    public class SeatController : Controller
    {

        SeatsEntities db = new SeatsEntities();

        public ActionResult Seat_Menu()
        {
            return View();
        }
        public ActionResult Block_Seat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Block_Seat(Seattbl seat)
        {
            TempData["BlockMessage"] = "<script>alert('Successfully blocked your seats')</script>";
            return RedirectToAction("Payment", "Seats");
        }
        public ActionResult Book_Seat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Book_Seat(Seattbl seat)
        {
            TempData["BookMessage"] = "<script>alert('Successfully booked your seats')</script>";
            return RedirectToAction("Payment", "Seats");
        }
        public ActionResult Cancel_Seat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cancel_Seat(Seattbl seat)
        {
            TempData["CancelMessage"] = "<script>alert('Successfully Canceled your seats')</script>";
            return RedirectToAction("Payment", "Seats");
        }
        public ActionResult Payment()
        {
            return View();
        }
    }
}