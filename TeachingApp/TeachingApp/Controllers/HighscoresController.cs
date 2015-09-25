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
    public class HighscoresController : Controller
    {
        //private TeachingContext db = new TeachingContext();

        private TeachingRepository repo = new TeachingRepository();


        // GET: Highscores
        public ActionResult Index()
        {

            return View(repo.GetHighscores().OrderByDescending(s=>s.Score).ThenByDescending(d=>d.Submitted));
        }

        // POST: HighScores/Index
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ID,Name,Score")] Highscore highscore)
        {
            return View(highscore);
        }

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
