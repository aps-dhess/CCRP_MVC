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

        public ActionResult Index(string subject = null)
        {
            var TeamSubject = Server.HtmlEncode(subject);
            ViewBag.Subject = TeamSubject;

            //var model = _db.Coaches.ToList();

            var model =
               from c in _db.Coaches
               join s in _db.Subjects on c.Subject_ID equals s.ID
               where (s.Title == subject)
               select new CoachListView {NameFull = c.NameFull, JobTitle = c.JobTitle, EmailAddress = c.EmailAddress, ProfileImgUrl = c.ProfileImgUrl, Subject = s.Title};

          
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
