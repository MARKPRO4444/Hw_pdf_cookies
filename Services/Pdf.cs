using System;
using System.Text;
using Hw_pdf_cookies.Services.Interfaces;
using PdfSharp;

namespace Hw_pdf_cookies.Services;

public class Pdf : IPdf
{
    public void GeneratePdf(string text)
    {
        // Ensure the encoding provider is registered
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }
}
