﻿using CICDMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CICDMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //for commit test
            // New commit on Dev.

            // Login Page feature implemented
            // new commit to test triggers
            _logger = logger;
        }
        // Development code implemented
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
            //user test commit
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
