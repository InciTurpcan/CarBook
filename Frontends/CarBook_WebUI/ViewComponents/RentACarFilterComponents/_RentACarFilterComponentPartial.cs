using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(string v) 
        {
            v = "aaa";
            TempData["value"] = v;
            return View();
        }
    }
}
