using System;
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
    public class ColorsController : Controller
    {
        private TeachingRepository repo = new TeachingRepository();

        // GET: Colors
        public ActionResult Index()
        {
            Random r = new Random();
            return View(repo.GetColorById(r.Next(1, 5)));
        }

        // GET: Colors/Details/5
        /*public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Color color = db.Color.Find(id);
            if (color == null)
            {
                return HttpNotFound();
            }
            return View(color);
        }

        // GET: Colors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ColorText")] Color color)
        {
            if (ModelState.IsValid)
            {
                //db.Color.Add(color);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(color);
        }

        // GET: Colors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Color color = db.Color.Find(id);
            if (color == null)
            {
                return HttpNotFound();
            }
            return View(color);
        }

        // POST: Colors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ColorText")] Color color)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(color).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(color);
        }
        */
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
