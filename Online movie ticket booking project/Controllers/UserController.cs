using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieTicketBooking.Models;

namespace OnlineMovieTicketBooking.Controllers
{
    public class UserController : Controller
    {
        OnlineMovieTicketEntities33 db = new OnlineMovieTicketEntities33();
        // GET: User

        public ActionResult Index()
        {
            return View(db.Table_User.ToList());
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Table_User user)
        {
            if (db.Table_User.Any(x => x.UserName == user.UserName))
            {
                ViewBag.Notification = "This User is already existed";
                return View();
            }
            else
            {
                TempData["RegisterMessage"] = "<script>alert('User Register successfully')</script>";
                db.Table_User.Add(user);
                db.SaveChanges();
                return RedirectToAction("Signin", "User");
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Table_User user)
        {
            if (ModelState.IsValid == true)
            {
                db.Table_User.Add(user);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertMessage"] = "<script>alert('Data Inserted successfully!!')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["InsertMessage"] = "<script>alert(' Not Inserted!!')</script>";
                }
            }
            return View();
        }
        public ActionResult Signout()
        {
            TempData["SignoutMessage"] = "<script>alert('User Signout successfully')</script>";
            Session.Clear();
            return RedirectToAction("Register", "User");
        }
        [HttpGet]
        public ActionResult Signin(string UserName, string Password)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signin(Table_User user)
        {
            var checklogin = db.Table_User.Where(x => x.UserName.Equals(user.UserName) && x.Password.Equals(user.Password)).FirstOrDefault();
            if (checklogin != null)
            {
                Session["UId"] = user.UserId.ToString();
                Session["UName"] = user.UserName.ToString();
                TempData["SigninMessage"] = "<script>alert('User Signin successfully')</script>";
                return RedirectToAction("Seat_Menu", "Seats");
            }
            else
            {
                ViewBag.Notification = "Incorrect Username or Password";
            }

            return View();
        }

    }
}