﻿using AspMVCExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMVCExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Employee e)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}