﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SP749415_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS 4200 Test Developer";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Info about me";

            return View();
        }
    }
}