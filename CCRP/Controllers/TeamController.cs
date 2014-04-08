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

        public ActionResult Index(string subject, string grade)
        {
            var TeamSubject = Server.HtmlEncode(subject);
            ViewBag.Subject = TeamSubject;
            
            var TeamGrade = Server.HtmlEncode(grade);
            ViewBag.Grade = TeamGrade;

            var message = String.Format("{0}:{1}", TeamSubject, TeamGrade);
            ViewBag.Message = message;
          
            return View();
        }

    }
}
