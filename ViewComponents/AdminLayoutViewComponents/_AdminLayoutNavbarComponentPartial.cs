﻿using Microsoft.AspNetCore.Mvc;

namespace PirasyonelWebsite.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutNavbarComponentPartial: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
