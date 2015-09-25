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
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            Random r = new Random();
            var color = repo.GetColorById(r.Next(1, 6));
            ColorViewModel viewModel = new ColorViewModel()
            {
                ID = color.ID,
                ColorText = color.ColorText
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ID,ColorText,UserResponse")] ColorViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (repo.GetColorById(viewModel.ID).ID == viewModel.UserResponse)
                {
                    ViewBag.Message = "Good answer.";
                    Highscore newHighscore = new Highscore();
                    newHighscore.Score += 1;
                    repo.SetHighscore(newHighscore.ID, newHighscore.Score);
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
