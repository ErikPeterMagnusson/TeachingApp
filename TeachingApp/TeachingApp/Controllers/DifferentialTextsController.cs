﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TeachingApp.DataConnectionlayer;
using TeachingApp.Models;
using TeachingApp.Repositories;

namespace TeachingApp.Controllers
{
    public class DifferentialTextsController : Controller
    {
        private TeachingContext db = new TeachingContext(); //Ska inte finnas, därför ni har en repo
        private TeachingRepository repo = new TeachingRepository();

        // GET: DifferentialTexts
        public ActionResult Index()
        {
            return View(repo.GetAllDifferentialTexts());
        }
        /*
        [HttpPost]
        public ActionResult differentialInput ()
        {
            if (repo.CompareDifferentialInput( = true) { Console.WriteLine="true" }
            Console.WriteLine="false";
        }
        */
        // GET: DifferentialTexts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DifferentialText differentialText = db.DifferentialText.Find(id);
            if (differentialText == null)
            {
                return HttpNotFound();
            }
            return View(differentialText);
        }

        // GET: DifferentialTexts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DifferentialTexts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ShowText,GoodText")] DifferentialText differentialText)
        {
            if (ModelState.IsValid)
            {
                db.DifferentialText.Add(differentialText);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(differentialText);
        }

        // GET: DifferentialTexts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DifferentialText differentialText = db.DifferentialText.Find(id);
            if (differentialText == null)
            {
                return HttpNotFound();
            }
            return View(differentialText);
        }

        // POST: DifferentialTexts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ShowText,GoodText")] DifferentialText differentialText)
        {
            if (ModelState.IsValid)
            {
                db.Entry(differentialText).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(differentialText);
        }

        // GET: DifferentialTexts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DifferentialText differentialText = db.DifferentialText.Find(id);
            if (differentialText == null)
            {
                return HttpNotFound();
            }
            return View(differentialText);
        }

        // POST: DifferentialTexts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DifferentialText differentialText = db.DifferentialText.Find(id);
            db.DifferentialText.Remove(differentialText);
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
