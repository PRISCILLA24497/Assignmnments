using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieTicketBooking.Models;

namespace OnlineMovieTicketBooking.Controllers
{
    public class MovieController : Controller
    {
        OnlineMovieTicketEntities34 me = new OnlineMovieTicketEntities34();
        // GET: Movie
        public ActionResult Movie()
        {
            return View(me.tbl_Movie.ToList());
        }
    }
}