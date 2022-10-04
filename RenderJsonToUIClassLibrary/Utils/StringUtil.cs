namespace RenderJsonToUIClassLibrary.Utils
{
    public class StringUtil
    {
        private const string EndHeaderTag = "</header>";
        private const string EndMainTag = "</main>";

        private static int _indexOfEndHeaderTag = LayoutUtil.LayoutContent.IndexOf(EndHeaderTag);
        private static int _indexOfEndMainTag = LayoutUtil.LayoutContent.IndexOf(EndMainTag);
        private static int _totalLengthOfHeader = _indexOfEndHeaderTag + EndHeaderTag.Length;
        private static int _totalLengthFromHeaderToMain = _indexOfEndMainTag + EndMainTag.Length;
        private static int _mainStartFrom = _totalLengthOfHeader + 1;
        private static int _footerStartFrom = _totalLengthFromHeaderToMain + 1;
        public static string BannerId = GenerateIdOfElement(LayoutUtil.Banner);
        public static string ContentId = GenerateIdOfElement(LayoutUtil.Content);
        public static string PageContentId = GenerateClassOfElement("page-content");
        public static string GetHeaderFromLayoutContent()
            => LayoutUtil.LayoutContent.Substring(0, _totalLengthOfHeader);

        public static string GetMainFromLayoutContent()
            => LayoutUtil.LayoutContent.Substring(_mainStartFrom, _totalLengthFromHeaderToMain - _mainStartFrom);

        public static string GetFooterFromLayoutContent() 
            => LayoutUtil.LayoutContent.Substring(_footerStartFrom);

        public static List<string> ToList(string stringToSplit,  string separator) 
            => stringToSplit.Split(separator).ToList();

        public static string GenerateIdOfElement(string name) => $"id=\"{name}\"";
        public static string GenerateClassOfElement(string name) => $"class=\"{name}\"";



    }
}
