using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Hw_pdf_cookies.Models;

namespace Hw_pdf_cookies.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
