using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PVEHackathon.Models;

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

        public ActionResult Index()
        {
            List<Ideas> ideas = new List<Ideas>(); 
            
            for (int i = 0; i < 5; i++)
            {
                var idea = new Ideas();
                idea.autor = "User" + i;
                idea.problema = "Problema" + i;
                idea.titulo = "Titulo" + i;
                idea.solucion = "Solucion" + i;
                ideas.Add(idea);
            }
            if (ideas == null)
            {
                return HttpNotFound();
            }
           // ideas.Count();
            ViewBag.Ideas = ideas;
            return View(ideas);
        }

    }
}