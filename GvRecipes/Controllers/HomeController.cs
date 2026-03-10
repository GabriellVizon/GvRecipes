using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GvRecipes.Models;
using GvRecipes.Data;

namespace GvRecipes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(
        ILogger<HomeController> logger,
        AppDbContext appDb
    )
    {
        _logger = logger;
        _db = appDb;
    }

    public IActionResult Index()
    {
        var receitas = _db.Receitas.ToList();
        ViewData["Categorias"] = _db.Categorias.ToList();
        return View(receitas);
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
