namespace BlazorWASMPagination.Models
{
    public class PageItem
    {
        public PageItem(int pageIndex, bool enabled, string text)
        {
            PageIndex = pageIndex;
            Enabled = enabled;
            Text = text;
        }

        public string Text { get; set; }
        public int PageIndex { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;
    }
}
