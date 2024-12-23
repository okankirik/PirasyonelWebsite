using Microsoft.AspNetCore.Mvc;
using PirasyonelWebsite.DAL.Context;

namespace PirasyonelWebsite.Controllers
{
    public class WoodenStandController : Controller
    {
        private readonly PirasyonelContext _context;

        public WoodenStandController(PirasyonelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.woodenStands.ToList();
            return View(values);
        }

    }
}
