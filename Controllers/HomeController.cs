using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Menghi.Massimo._5H.PrimaWeb.Models;

namespace Menghi.Massimo._5H.PrimaWeb.Controllers
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

        public IActionResult Persone()
        {
            List<Persona> p = new List<Persona>();
            p.Add(
                new Persona{ID = 1, Nome = "Massimo", Cognome = "Menghi"});

            p.Add(
                new Persona{ID = 2, Nome = "Fabio", Cognome = "Caralli"});
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
