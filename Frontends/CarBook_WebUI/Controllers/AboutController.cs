﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
