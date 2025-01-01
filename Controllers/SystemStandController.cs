using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PirasyonelWebsite.DAL.Context;

namespace PirasyonelWebsite.Controllers;

public class SystemStandController : Controller
{
    private readonly PirasyonelContext _context;

    public SystemStandController(PirasyonelContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var values = _context.systemStands.ToList();
        return View(values);
    }

    public IActionResult PortfolioDetail()
    {
        return View();
    }

    public IActionResult AdminSystemStandPage()
    {
        return View();
    }
}
