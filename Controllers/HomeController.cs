using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aplicaci_n_de_Remesas_Internacionales_con_Gesti_n_de_Transacciones_en_D_lares_y_Bitcoin.Models;

namespace Aplicaci_n_de_Remesas_Internacionales_con_Gesti_n_de_Transacciones_en_D_lares_y_Bitcoin.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
