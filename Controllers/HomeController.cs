using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinalPrep.Models;

namespace FinalPrep.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }

}

