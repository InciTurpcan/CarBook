using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.ViewComponents.CommandViewComponent
{
    public class _CommentListByBlogComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }

    }
}
