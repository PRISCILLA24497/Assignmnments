using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieTicketBooking.Models;

namespace OnlineMovieTicketBooking.Controllers
{
    public class CityController : Controller
    {
        CityEntities dbObj = new CityEntities();
        // GET: City
        public ActionResult City()
        {
            return View();
        }
        [HttpPost]
        public ActionResult City(tbl_City1 City)
        {
            try
            {
                dbObj.tbl_City1.Add(City);
                // ViewBag.SucessMessage = "New User Record Sucessfully";
                dbObj.SaveChanges();
                return RedirectToAction("BookTicket", "Payment");
            }
            catch
            {
                return RedirectToAction("BookTicket", "Payment");
            }
        }
    }
}