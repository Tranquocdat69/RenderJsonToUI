using Microsoft.AspNetCore.Mvc.RazorPages;
using RenderJsonToUIClassLibrary.Models;
using RenderJsonToUIClassLibrary.Utils;

namespace RenderJsonToUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PageUI _pageUI; 
        private readonly List<PageModuleUI> _listPageModule; 
        private const string _pageName = "Trang chủ";
        public string HTMLContent = String.Empty;
        public string Title { get; set; }

        public IndexModel()
        {
            _pageUI = PageUIUtil.ListPages.Where(x => x.PageName.Equals(_pageName)).FirstOrDefault();
            _listPageModule = _pageUI.ListPageModule;
            Title = _pageUI.Title;
        }

        public void OnGet()
        {
            List<string> listMain = ListUtil.RenderPageModuleToMainSection(_listPageModule);

            listMain.ForEach(item => HTMLContent += item);
            HTMLContent = "<div class=\"container body-content\">" + HTMLContent + "</div>";
        }
    }
}