using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsAuthorAboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
