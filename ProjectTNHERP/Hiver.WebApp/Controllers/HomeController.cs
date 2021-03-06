﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hiver.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Hiver.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Hiver.ApiIntegration.Menu;

namespace Hiver.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMenuApiClient _menuApiClient;

        public HomeController(ILogger<HomeController> logger, IMenuApiClient menuApiClient)
        {
            _logger = logger;
            _menuApiClient = menuApiClient;
        }

        public IActionResult Index()
        {
            var user = User.Identity.Name;

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



        public IActionResult NoPermission()
        {
            return View("NoPermission");
        }
    }
}