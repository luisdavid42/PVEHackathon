using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PVEHackathon.Models;

namespace PVEHackathon.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult EventosMain()
        {
            return View();
        }

        public ActionResult Index()

        {
            List<Eventos> eventos = new List<Eventos>();

            for (int i = 0; i < 5; i++)
            {
                var evento = new Eventos();
                evento.nombre = "User" + i;
                evento.descripcion = "Economía Nacional";
                evento.fechaInico = new DateTime(2016, 11, 30);
                evento.fechaClausura = new DateTime(2016, 11, 30);
                var idea = new Ideas();
                idea.agregarLike("20093278");
                idea.agregarLike("20093918");
                idea.agregarLike("20086787");
                idea.agregarLike("20096787");

                evento.ideas.Add(idea);

                eventos.Add(evento);
            }
            if (eventos == null)
            {
                return HttpNotFound();
            }
            // ideas.Count();
            ViewBag.Eventos = eventos;
            return View(eventos);
        }

    }
}
