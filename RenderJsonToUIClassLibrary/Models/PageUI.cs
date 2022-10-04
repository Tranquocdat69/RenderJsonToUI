namespace RenderJsonToUIClassLibrary.Models
{
    public class PageUI
    {
        public string PageId { get; set; }
        public int? PageOrder { get; set; }
        public string ApplicationID { get; set; }
        public string PageName { get; set; }
        public int? PageType { get; set; }
        public string PageContent { get; set; }
        public bool IsVisible { get; set; }
        public string ParentID { get; set; }
        public string IconFile { get; set; }
        public bool DisableLink { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public bool IsDeleted { get; set; }
        public string Url { get; set; }
        public string LayoutID { get; set; }
        public string LayoutName { get; set; }
        public LayoutUI Layout { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? RefreshInterval { get; set; }
        public string PageHeadText { get; set; }
        public bool IsSecure { get; set; }
        public string IconFileLarge { get; set; }
        public int? Level { get; set; }
        public string PagePath { get; set; }
        public bool HasBeenPublished { get; set; }
        public bool IsSystem { get; set; }
        public string CreatedByUserID { get; set; }
        public string CreatedOnDate { get; set; }
        public string LastModifiedByUserID { get; set; }
        public string LastModifiedOnDate { get; set; }
        public string TemplatePageId { get; set; }
        public bool TemplatePageModuleInherit { get; set; }
        public bool DeleteSuccess { get; set; }
        public List<PageModuleUI> ListPageModule { get; set; }
    }
}
