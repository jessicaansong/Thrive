﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charm.Controllers
{
    [RequireHttps]
    public class WorksController : Controller
    {
        // GET: Works
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult JavaScriptExercises()
        {
            return View();
        }
    }
}