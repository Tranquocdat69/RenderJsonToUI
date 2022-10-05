using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RenderJsonToUIClassLibrary.Models;
using RenderJsonToUIClassLibrary.Utils;

namespace RenderJsonToUI.Pages
{
    public class HomeModel : PageModel
    {
        public readonly PageUI PageUI;
        private const string _pageName = "Trang chủ";
        public string HTMLContent = String.Empty;
        public string Title { get; set; }

        public string PageId { get; set; }

        public HomeModel()
        {
            PageUI = PageUIUtil.ListPages.Where(x => x.PageName.Equals(_pageName)).FirstOrDefault();
            Title = PageUI.Title;
            PageId = PageUI.PageId;
        }

        public void OnGet()
        {
            List<string> listMain = ListUtil.RenderPageModuleToMainSection(PageUI.ListPageModule);

            listMain.ForEach(item => HTMLContent += item);
            HTMLContent = "<div class=\"container body-content\">" + HTMLContent + "</div>";
        }
    }
}