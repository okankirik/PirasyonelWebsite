using Microsoft.AspNetCore.Mvc;

namespace PirasyonelWebsite.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
