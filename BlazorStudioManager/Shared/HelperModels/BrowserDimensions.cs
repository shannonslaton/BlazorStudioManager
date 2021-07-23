using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.HelperModels
{
    public class BrowserDimensions
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string GridWidth { get; set; }
        public string GridHeight { get; set; }
        public string FormWidth { get; set; }
        public string FormHeight { get; set; }
        public string GalleryWidth { get; set; }
        public string GalleryHeight { get; set; }
        public string InnerGalleryWidth { get; set; }
        public string InnerGalleryHeight { get; set; }
        public int RowHeight { get; set; }
        public int PageSize { get; set; } = 15;
        public int GalleryPageSize { get; set; } = 20;
        public string SplitterOrientation { get; set; } = "Horizontal";
        public string ImagePaneSize { get; set; }
        public int ColSpan { get; set; } = 4;
        public string GridOrGallery { get; set; } = "Gallery";
        public string ImageSize { get; set; } = "200px;";
        public string ImageContainerSize { get; set; } = "240px;";
    }
}
