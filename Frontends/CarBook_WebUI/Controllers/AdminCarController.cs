﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
