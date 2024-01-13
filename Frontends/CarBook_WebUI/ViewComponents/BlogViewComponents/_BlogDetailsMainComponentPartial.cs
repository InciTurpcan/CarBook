using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsMainComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
