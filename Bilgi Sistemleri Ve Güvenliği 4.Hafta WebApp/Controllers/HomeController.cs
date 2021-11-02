using System;
using Bilgi_Sistemleri_Ve_Güvenliği_4.Hafta_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Bilgi_Sistemleri_Ve_Güvenliği_4.Hafta_WebApp.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult LoggedIn()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Submit(CaptchaCodeModel model)
        {
            if (model.CaptchaCode.Equals("A6MGB"))
            {
                return RedirectToAction("LoggedIn","Home");
            }

            return Index();
        }
    }
}
