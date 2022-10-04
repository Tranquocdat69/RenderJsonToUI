using Microsoft.AspNetCore.Mvc;

namespace RenderJsonToUI.ViewComponents
{
    public class MainViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Main", "This is Main");
        }
    }
}
