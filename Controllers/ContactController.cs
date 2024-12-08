using Microsoft.AspNetCore.Mvc;

namespace PirasyonelWebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
