using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PirasyonelWebsite.DAL.Context;
using PirasyonelWebsite.DAL.Entities;
using PirasyonelWebsite.Utils;

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
    public async Task<IActionResult> CreateAdminSystemStand()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAdminSystemStand(SystemStand systemStand, IFormFile Image1,  IFormFile Image2, IFormFile? Image3, IFormFile? Image4, IFormFile? Image5)
    {
        if (ModelState.IsValid)
        {
            try
            {
                systemStand.Image1 = await FileHelper.FileLoaderAsync(Image1, "/images/SystemStand/");
                systemStand.Image2 = await FileHelper.FileLoaderAsync(Image2, "/images/SystemStand/");
                systemStand.Image3 = await FileHelper.FileLoaderAsync(Image3, "/images/SystemStand/");
                systemStand.Image4 = await FileHelper.FileLoaderAsync(Image4, "/images/SystemStand/");
                systemStand.Image5 = await FileHelper.FileLoaderAsync(Image5, "/images/SystemStand/");
                await _context.systemStands.AddAsync(systemStand);
                await _context.SaveChangesAsync();
                return RedirectToAction("AdminSystemStandList");
            }
            catch
            {
                ModelState.AddModelError("", "Stand ekleme başarısız. Lütfen tekrar deneyin.");
            }
        }
        return View(systemStand);
    }
}
