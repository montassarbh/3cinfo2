﻿using Gambling.Data.Infrastructure;
using Gambling.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gambling.Web.Controllers
{
    [Authorize(Users = "Ghassen")]
    public class RatController : Controller
    {

        DatabaseFactory dbFactory = null;
        UnitOfWork unitOfwork = null;
        public RatController()
        {
            dbFactory = new DatabaseFactory();
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
            return View(unitOfwork.RatRepository.GetById(id));
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
        public ActionResult Create(Rat rat)
        {
            try
            {
                unitOfwork.RatRepository.Add(rat);
                unitOfwork.Commit();
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
            return View(unitOfwork.RatRepository.GetById(id));
        }

        //
        // POST: /Rat/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Rat rat)
        {
            try
            {
                // TODO: Add update logic here
                unitOfwork.RatRepository.Update(rat);
                unitOfwork.Commit();
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
            return View(unitOfwork.RatRepository.GetById(id));
        }

        //
        // POST: /Rat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Rat rat)
        {
            try
            {
                // TODO: Add delete logic here
                unitOfwork.RatRepository.Delete(unitOfwork.RatRepository.GetById(id));
                unitOfwork.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
