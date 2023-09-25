﻿using CICDMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CICDMVCApp.Controllers
{
    public class HomeController : Controller
    {
    // sample commit
    // Commit on Dev to test the azure pipeline triggerred
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
