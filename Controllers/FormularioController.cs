using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app_remesas_parcial.Data;
using app_remesas_parcial.Models;

namespace app_remesas_parcial.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ILogger<RegistroController> _logger;
        private readonly ApplicationDbContext _context;

        public RegistroController(ILogger<RegistroController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(transacciones transacciones)
        {
            transacciones.CalcularMonto();
            _context.Add(transacciones);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}