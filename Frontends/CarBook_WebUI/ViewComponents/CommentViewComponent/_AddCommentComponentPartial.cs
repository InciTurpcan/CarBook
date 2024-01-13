using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebUI.ViewComponents.CommentViewComponent
{
    public class _AddCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
