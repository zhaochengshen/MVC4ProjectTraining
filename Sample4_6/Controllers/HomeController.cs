﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample4_6.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
