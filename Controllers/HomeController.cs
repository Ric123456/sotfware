using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaMVCLogin.Models;
using PruebaMVCLogin.Data;

namespace PruebaMVCLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
             _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Catalogo()
        {
            return View();
        }

         public IActionResult Requerimiento()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Requerimiento(Informacion obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            ViewData["Message"] = "Mensaje Recibido";
            //return RedirectToAction(nameof(Index));
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
