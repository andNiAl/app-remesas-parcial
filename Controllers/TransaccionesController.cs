using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app_remesas_parcial.Data;
using app_remesas_parcial.Models;
using System.Transactions;

namespace app_remesas_parcial.Controllers
{
    public class TransaccionesController : Controller
    {
        private readonly ILogger<TransaccionesController> _logger;
        private readonly ApplicationDbContext _context;

        public TransaccionesController(ILogger<TransaccionesController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var transacciones = from o in _context.DataTransacciones select o;
            return View(transacciones);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}