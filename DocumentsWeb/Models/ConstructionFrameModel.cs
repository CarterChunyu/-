namespace DocumentsWeb.Models
{
    public class ConstructionFrameModel
    {
        // 檔案亂碼
        public Guid guid { get; set; }
        // 檔名
        public string Filename { get; set; } 
        // 標題
        public string Title1 { get; set; }
        // 標題
        public string Title2 { get; set; }
        // 標題
        public string Title3 { get; set; }
        // 施工單位
        public string ConstructionUnit { get; set; }

        // 設計單位
        public string DesignUnit { get; set; }

    }
}
