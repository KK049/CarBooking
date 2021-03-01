using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarBooking.Controllers
{
    public class CarBookingController : Controller
    {
        // GET: CarBooking
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarBooking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarBooking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarBooking/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CarBooking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarBooking/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CarBooking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarBooking/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
