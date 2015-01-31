using Gambling.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gambling.Web.Controllers
{
    public class RatController : Controller
    {

        DatabaseFactory dbFactory = null;
        UnitOfWork unitOfwork = null;
        public RatController()
        {
            dbFactory=new DatabaseFactory();
            unitOfwork = new UnitOfWork(dbFactory);

        }
        //
        // GET: /Rat/
        public ActionResult Index()
        {


            return View(unitOfwork.RatRepository.GetAll());
        }

        //
        // GET: /Rat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Rat/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Rat/Create
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

        //
        // GET: /Rat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Rat/Edit/5
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

        //
        // GET: /Rat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Rat/Delete/5
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
