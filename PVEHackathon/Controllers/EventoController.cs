﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PVEHackathon.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult EventosMain()
        {
            return View();
        }
    }
}