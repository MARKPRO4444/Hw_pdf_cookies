using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Hw_pdf_cookies.Models;
using Hw_pdf_cookies.Services.Interfaces;

namespace Hw_pdf_cookies.Controllers;

public class PdfController : Controller
{
    private readonly IPdf pdf;

    public PdfController(IPdf pdf)
    {
        this.pdf = pdf;
    }
    
    public IActionResult Index()
    {
        return View();
    }
}
