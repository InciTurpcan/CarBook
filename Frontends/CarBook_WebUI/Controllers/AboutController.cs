﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımızda";
            ViewBag.v2 = "Vizyonuzmuz & Misyonumuz";
            return View();
        }
    }
}
