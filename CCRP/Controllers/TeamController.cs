using CCRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CCRP.Controllers
{
    public class TeamController : Controller
    {
        //
        // GET: /Team/
        CCRPdb _db = new CCRPdb();

        public ActionResult Index(string subject, string grade)
        {
            var TeamSubject = Server.HtmlEncode(subject);
            ViewBag.Subject = TeamSubject;
            
            var TeamGrade = Server.HtmlEncode(grade);
            ViewBag.Grade = TeamGrade;

            var message = String.Format("{0}:{1}", TeamSubject, TeamGrade);
            ViewBag.Message = message;

            var model = _db.Subjects.ToList();
          
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null) {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
