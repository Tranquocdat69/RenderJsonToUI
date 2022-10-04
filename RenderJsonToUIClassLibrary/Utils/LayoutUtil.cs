namespace RenderJsonToUIClassLibrary.Utils
{
    public class LayoutUtil
    {
        public static string LayoutContent = PageUIUtil.ListPages[0].Layout.LayoutContent;
        public static string LayoutPosition = PageUIUtil.ListPages[0].Layout.LayoutPosition;

        public static List<string> ListLayoutPosition = LayoutPosition.Split(";").ToList();
        public static string Banner = ListLayoutPosition[1];
        public static string Content = ListLayoutPosition[2];
    }
}
