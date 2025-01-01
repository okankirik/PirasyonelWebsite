using Microsoft.AspNetCore.Mvc;

namespace PirasyonelWebsite.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutHeadComponentPartial: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
