using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PVEHackathon.Controllers
{
    public class IdeaController : Controller
    {
        // GET: Idea
        public ActionResult IdeasMain()
        {
            return View();
        }
        public ActionResult IdeaUnica()
        {
            return View();
        }
    }
}