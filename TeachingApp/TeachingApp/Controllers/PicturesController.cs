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
    public class PicturesController : Controller
    {
        private TeachingRepository repo = new TeachingRepository();

        // GET: Pictures .GetPictureById(r.Next(1, 5))
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            Random r = new Random();
            var picture = repo.GetPictureById(r.Next(1, 5));

            PictureViewModel viewModel = new PictureViewModel()
            {
                 ID = picture.ID,
                 Name = picture.Name,
                 Word = picture.Word
            };
            return View(viewModel); //
        }
        // POST: Pictures/Index
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ID,Name,Word,UserResponse")] PictureViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (repo.ComparePicture(viewModel.ID, viewModel.UserResponse))
                {
                    ViewBag.Message = "Good answer.";
                    return RedirectToAction("Index", new { message = ViewBag.Message });
                }
                else
                {
                    ViewBag.Message = "Sorry! Wrong answer.";
                    return View(viewModel);
                }

                return RedirectToAction("Index", new { message = ViewBag.Message });
                //return View();
            }

            return View();
        }
        /*
        // GET: Pictures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Picture picture = db.Picture.Find(id);
            if (picture == null)
            {
                return HttpNotFound();
            }
            return View(picture);
        }

        // GET: Pictures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pictures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Word")] Picture picture)
        {
            if (ModelState.IsValid)
            {
                db.Picture.Add(picture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(picture);
        }

        // GET: Pictures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Picture picture = db.Picture.Find(id);
            if (picture == null)
            {
                return HttpNotFound();
            }
            return View(picture);
        }

        // POST: Pictures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Word")] Picture picture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(picture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(picture);
        }

        // GET: Pictures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Picture picture = db.Picture.Find(id);
            if (picture == null)
            {
                return HttpNotFound();
            }
            return View(picture);
        }

        // POST: Pictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Picture picture = db.Picture.Find(id);
            db.Picture.Remove(picture);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        */
        // GET: Pictures/BildTest
        //public ActionResult BildTest()
        //{
        //    PictureViewModel viewModel = new PictureViewModel();

        //    return View(viewModel);
        //}

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
