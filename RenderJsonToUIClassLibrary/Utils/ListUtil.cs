
namespace RenderJsonToUIClassLibrary.Utils
{
    public static class ListUtil
    {
        private const string Separator = "\n";

        public static void AppendDiv(this List<string> list, int index, string div)
        {
            list.Insert(index, div);
            list.Insert(list.Count, "</div>");
        }

        public static void AppendClass(this List<string> list, int index, string className)
            => list[index] = list[index].Replace("class=\"", $"class=\"{className} ");

        public static List<string> CustomSectionMain(this List<string> sectionMain)
        {
            int lengthOfSectionMain = sectionMain.Count;

            for (int i = 0; i < lengthOfSectionMain; i++)
            {
                string item = sectionMain[i];
                if (item.Contains(StringUtil.PageContentId))
                    sectionMain.AppendDiv(i + 1, "<div class=\"row\">");

                if (item.Contains(StringUtil.BannerId))
                {
                    sectionMain.AppendClass(i, "col-md-3");
                    sectionMain.AppendClass(i, "border border-success");
                }

                if (item.Contains(StringUtil.ContentId))
                {
                    sectionMain.AppendClass(i, "col-md-9");
                    sectionMain.AppendClass(i, "border border-info");
                }
            }
            return sectionMain;
        }

        public static List<string> RenderPageModuleToMainSection(List<PageModuleUI> listPageModuleUI)
        {
            string headerFromLayoutContent = StringUtil.GetHeaderFromLayoutContent();
            string mainFromLayoutContent = StringUtil.GetMainFromLayoutContent();
            string footerFromLayoutContent = StringUtil.GetFooterFromLayoutContent();
            List<string> sectionHeader = StringUtil.ToList(headerFromLayoutContent, Separator);
            List<string> sectionMain = StringUtil.ToList(mainFromLayoutContent, Separator);
            List<string> sectionFooter = StringUtil.ToList(footerFromLayoutContent, Separator);
            List<string> layout = new();

            sectionMain.CustomSectionMain();

            layout.AddRange(sectionHeader);
            layout.AddRange(sectionMain);
            layout.AddRange(sectionFooter);

            List<PageModuleUI> orderPageModuleUI = listPageModuleUI.OrderBy(p => p.ModuleOrder).ToList();
            for (int i = 0; i < orderPageModuleUI.Count; i++)
            {
                PageModuleUI pageModuleUI = orderPageModuleUI[i];
                string positionId = StringUtil.GenerateIdOfElement(pageModuleUI.Position);
                for (int j = 0; j < layout.Count; j++)
                {
                    string valueSectionMain = layout[j];
                    if (valueSectionMain.Contains(positionId))
                    {
                        layout[j] = valueSectionMain.Replace("</div>", $"{pageModuleUI.ModuleName} {pageModuleUI.ModuleContent} </div>");
                    }
                }
            }
            return layout;
        }
    }
}
