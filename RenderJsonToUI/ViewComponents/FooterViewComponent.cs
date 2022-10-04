using Microsoft.AspNetCore.Mvc;

namespace RenderJsonToUI.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Footer", "This is Footer");
        }
    }
}
