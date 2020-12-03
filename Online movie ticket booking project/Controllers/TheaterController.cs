using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieTicketBooking.Models;

namespace OnlineMovieTicketBooking.Controllers
{
    public class TheaterController : Controller
    {
        TheaterEntitites db = new TheaterEntitites();

       
        // GET: Theater
        public ActionResult Search_Menu()
        {
            return View();
        }
        public ActionResult SearchMovie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SearchMovie(Tbl_Theater theater)
        {
            if (db.Tbl_Theater.Any(x => x.MovieNames == theater.MovieNames && x.TheaterCity == theater.TheaterCity && x.ManagerName == theater.ManagerName && x.TheaterName == theater.TheaterName && x.TheaterId == theater.TheaterId && x.ListOfScreens == theater.ListOfScreens))
                ViewBag.Message = "Enjoy the movie";
            else
                ViewBag.Notification = " This Movie is not play in this theater";
            return View();
        }
        public ActionResult Search_Screen()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search_Screen(Tbl_Theater theater)
        {
            if (db.Tbl_Theater.Any(x => x.ListOfScreens == theater.ListOfScreens && x.TheaterId == theater.TheaterId && x.TheaterName == theater.TheaterName && x.MovieNames == theater.MovieNames && x.TheaterCity == theater.TheaterCity))
                ViewBag.Message1 = "Enjoy the movie with your wanted screen";
            else
                ViewBag.Notification1 = "No such screen type is available in this theater";
            return View();
        }
    }
}