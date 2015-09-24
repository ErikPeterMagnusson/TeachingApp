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
    public class SentencesController : Controller
    {
        private TeachingRepository repo = new TeachingRepository();

        // GET: 
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            Random r = new Random();
            var sentence = repo.GetSentenceById(r.Next(1, 5));

            SentenceViewModel viewModel = new SentenceViewModel()
            {
                 ID = sentence.ID,
                 Text = sentence.Text,
            };
            return View(viewModel); //
        }
        // POST: Pictures/Index
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ID,Text,UserResponse")] SentenceViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (repo.CompareSentence(viewModel.ID, viewModel.UserResponse))
                {
                    ViewBag.Message = "Good answer.";
                    return RedirectToAction("Index", new { message = ViewBag.Message });
                }
                else
                {
                    ViewBag.Message = "Sorry! Wrong answer.";
                    return View(viewModel);
                }
            }
            return View();
        }

        // GET: Sentences/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Sentence sentence = db.Sentence.Find(id);
        //    if (sentence == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(sentence);
        //}

        //// GET: Sentences/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Sentences/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Text")] Sentence sentence)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Sentence.Add(sentence);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(sentence);
        //}

        //// GET: Sentences/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Sentence sentence = db.Sentence.Find(id);
        //    if (sentence == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(sentence);
        //}

        //// POST: Sentences/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Text")] Sentence sentence)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(sentence).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(sentence);
        //}

        //// GET: Sentences/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Sentence sentence = db.Sentence.Find(id);
        //    if (sentence == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(sentence);
        //}

        //// POST: Sentences/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Sentence sentence = db.Sentence.Find(id);
        //    db.Sentence.Remove(sentence);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
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
