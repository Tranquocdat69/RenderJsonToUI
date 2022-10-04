namespace RenderJsonToUIClassLibrary.Models
{
    public class LayoutUI
    {
        public string LayoutID { get; set; }
        public int? LayoutOrder { get; set; }
        public string ApplicationID { get; set; }
        public string LayoutName { get; set; }
        public int? LayoutType { get; set; }
        public string LayoutContent { get; set; }
        public string LayoutPath { get; set; }
        public string IconFile { get; set; }
        public string CreatedByUserID { get; set; }
        public string CreatedOnDate { get; set; }
        public string LastModifiedByUserID { get; set; }
        public string LastModifiedOnDate { get; set; }
        public string LayoutPosition { get; set; }
        public string LayoutPathToShow { get; set; }
        public bool DeleteSuccess { get; set; }
    }
}
