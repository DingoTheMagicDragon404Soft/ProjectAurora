﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectAurora.Models;

namespace ProjectAurora.Controllers
{
    public class HomeController : Controller
    {
        private GameInfoDbContext db = new GameInfoDbContext();
        public ActionResult Index()
        {
           
            return View(db.NewsModels.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}