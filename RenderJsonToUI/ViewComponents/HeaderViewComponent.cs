using Microsoft.AspNetCore.Mvc;

namespace RenderJsonToUI.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Header", "This is Header");
        }
    }
}
