﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
