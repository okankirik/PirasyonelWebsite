using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PirasyonelWebsite.DAL.Context;
using PirasyonelWebsite.DAL.Entities;

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

    public IActionResult AdminSystemStandList()
    {
        var values = _context.systemStands.ToList();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateAdminSystemStand()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateAdminSystemStand(SystemStand systemStand)
    {
        _context.systemStands.Add(systemStand);
        _context.SaveChanges();
        return RedirectToAction("AdminSystemStandList");
    }
}
