using HangFireCore5.Hangfire;
using HangFireCore5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HangFireCore5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IHangfire _hangfire { get; set; }

        public HomeController(ILogger<HomeController> logger, IHangfire hangfire)
        {
            _logger = logger;
            _hangfire = hangfire;
        }

        public IActionResult Index()
        {
            //_hangfire.CreateNumber();
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
