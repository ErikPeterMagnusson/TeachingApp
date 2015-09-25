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

namespace TeachingApp.Controllers
{
    public class QuestionsController : Controller
    {
        private TeachingContext db = new TeachingContext();

        // GET: Questions
        public ActionResult Index()
        {
            return View(db.Question.ToList());
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
