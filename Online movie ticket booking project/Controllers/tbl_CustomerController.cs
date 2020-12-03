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
    public class tbl_CustomerController : Controller
    {
        DbModels db = new DbModels();

        // GET: tbl_Customer
        public ActionResult Index()
        {

            return View(db.tbl_Customer.ToList());

        }

        // GET: Customer/Details/5


        public ActionResult Details(int id)
        {

            return View(db.tbl_Customer.Where(x => x.ID == id).FirstOrDefault());


        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(tbl_Customer customer)
        {
            TempData["RegisterMessage"] = "<script>alert('User Registered Sucessfully')</script>";
            try
            {
                db.tbl_Customer.Add(customer);
                // ViewBag.SucessMessage = "New User Record Sucessfully";
                //TempData["RegisterMessage"] = "<script>alert('User Register Sucessfully')</script>";
                db.SaveChanges();
                return RedirectToAction("Continue");
            }
            catch
            {
                TempData["RegisterMessage"] = "<script>alert('User Register Sucessfully')</script>";
                db.SaveChanges();
                Session["ID"] = customer.ID.ToString();
                Session["Name"] = customer.Name.ToString();
                return RedirectToAction("Continue");
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.tbl_Customer.Where(x => x.ID == id).FirstOrDefault());
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tbl_Customer customer)
        {
            try
            {

                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {

            return View(db.tbl_Customer.Where(x => x.ID == id).FirstOrDefault());

        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                tbl_Customer customer = db.tbl_Customer.Where(x => x.ID == id).FirstOrDefault();
                db.tbl_Customer.Remove(customer);
                db.SaveChanges();

                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Continue()
        {
            return View();
        }

    }
}