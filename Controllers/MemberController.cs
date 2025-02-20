using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspProject.Models;

namespace AspProject.Controllers;

public class MemberController : Controller
{
    private readonly ILogger<MemberController> _logger;

    public MemberController(ILogger<MemberController> logger)
    {
        _logger = logger;
    }

    public IActionResult Profile()
    {
        return View();
    }

    public IActionResult BorrowHistory()
    {
        return View();
    }
    public IActionResult Penalty()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
