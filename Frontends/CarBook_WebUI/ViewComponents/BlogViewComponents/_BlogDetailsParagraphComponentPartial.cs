using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsParagraphComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
