using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IESMvc.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IESMvc.Controllers;

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


    public IActionResult Ajax()
    {
        Thread.Sleep(2000);

        var depto = new List<Departamento>
        {
            new Departamento { DepartamentoID = 100, Nombre = "Biología"},
            new Departamento { DepartamentoID = 200, Nombre = "Matemáticas"}
        };

        var dict = new Dictionary<string, object>
        {
            { "status", StatusCodes.Status200OK },
            { "data", depto }
        };

        //return new StatusCodeResult(403);
        //return BadRequest(dict);
        
        return StatusCode(400, dict);

    }

}

