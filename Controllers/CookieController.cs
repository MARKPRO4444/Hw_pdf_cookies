using System;
using Microsoft.AspNetCore.Mvc;

namespace Hw_pdf_cookies.Controllers;

public class CookieController : Controller
{
    public IActionResult Index()
    {
        // Response.Cookies.Append("MarkTheBest", "Cause");

        foreach (var item in Request.Cookies)
        {
            System.Console.WriteLine(item.Key + " " + item.Value);
        }

        var cookie = Request.Cookies["MarkTheBest"];

        Response.Cookies.Delete("MarkTheBest");


        return View();
    }

    
    public IActionResult Settings()
    {
        ViewBag.Theme = "light";
        return View();
    }
}
