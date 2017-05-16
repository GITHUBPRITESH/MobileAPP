﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MobileAPP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["MessageNOT"] = "Your application description page not working.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["MessageALL"] = "Your contact page not working.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
