﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CozaStore.Models;

namespace CozaStore.Controllers;

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

    public IActionResult Blog()
    {
        return View();
    }

    public IActionResult Contatos()
    {
        return View();
    }

    public IActionResult Loja()
    {
        return View();
    }

    public IActionResult Produtos()
    {
        return View();
    }
    public IActionResult Termos()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
