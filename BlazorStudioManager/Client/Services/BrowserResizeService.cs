using Microsoft.JSInterop;
using BlazorStudioManager.Shared.HelperModels;
using System;
using System.Threading.Tasks;

namespace BlazorStudioManager.Client.Services
{
    public class BrowserResizeService
    {
        public static event Func<Task> OnResize;
        public readonly IJSRuntime js;

        public BrowserResizeService(IJSRuntime js)
        {
            this.js = js;
        }

        [JSInvokable]
        public static async Task OnBrowserResize()
        {
            await OnResize?.Invoke();
        }

        public async Task<string> GetGridHeight()
        {
            var height =  await js.InvokeAsync<int>("browserResize.getInnerHeight");
            var heightString = (height * .98).ToString() + "px";
            return heightString;
        }

        public async Task<string> GetGridWidth()
        {
            var width = await js.InvokeAsync<int>("browserResize.getInnerWidth");
            var widthString = (width * .99).ToString() + "px";
            return widthString;
        }

        public async Task<BrowserDimensions> GetDimensions(int CurrentRowHeight, bool IsInTab)
        {
            var WidthModifier = 15;
            var HeightModifier = 50;
            var minWidth = 320;
            var minHeight = 568;

            var switchWidth = 960;
            var switchHeight = 568;

            var Height = await js.InvokeAsync<int>("browserResize.getInnerHeight");
            var Width = await js.InvokeAsync<int>("browserResize.getInnerWidth");

            var GridWidth = (Width - WidthModifier - 0).ToString() + "px";
            var GridHeight = (Height - HeightModifier - 0).ToString() + "px";
            var GalleryWidth = (Width - WidthModifier - 0).ToString() + "px";
            var GalleryHeight = (Height - HeightModifier - 0).ToString() + "px";
            var InnerGalleryWidth = (Width - WidthModifier - 25).ToString() + "px";
            var InnerGalleryHeight = (Height - HeightModifier - 100).ToString() + "px";
            var SplitterOrientation = "Horizontal";
            var colSpan = 4;
            var gridOrGallery = "Gallery";
            var imageSize = "100px;";
            var imagerContainerSize = "140px;";

            if (Width > switchWidth)
            {
                gridOrGallery = "Grid";
                imageSize = "200px;";
                imagerContainerSize = "240px;";
            }

            if (Width < switchWidth)
            {
                colSpan = 12;
                SplitterOrientation = "Vertical";
                GridWidth = (switchWidth - WidthModifier - 25).ToString() + "px";
                GalleryWidth = (Width - WidthModifier).ToString() + "px";
                InnerGalleryWidth = (Width - WidthModifier - 25).ToString() + "px";
            }

            if (Height < switchHeight)
            {
                GridHeight = (Height - HeightModifier - 75).ToString() + "px";
                GalleryHeight = (Height - HeightModifier).ToString() + "px";
                InnerGalleryHeight = (Height - HeightModifier - 50).ToString() + "px";
            }

            if (Width < minWidth)
            {
                colSpan = 12;
                SplitterOrientation = "Vertical";
                GridWidth = (switchWidth - WidthModifier - 25).ToString() + "px";
                GalleryWidth = (minWidth - WidthModifier).ToString() + "px";
                InnerGalleryWidth = (minWidth - WidthModifier - 25).ToString() + "px";
            }

            if (Height < minHeight)
            {
                GridHeight = (switchHeight - HeightModifier - 75).ToString() + "px";
                GalleryHeight = (minHeight - HeightModifier).ToString() + "px";
                InnerGalleryHeight = (minHeight - HeightModifier - 50).ToString() + "px";
            }

            var PageSize = 15;
            var GalleryPageSize = 20;
            //var RowHeight = Height / 10;

            //if (RowHeight > CurrentRowHeight)
            //{
            //    PageSize = Height / CurrentRowHeight;
            //}

            var RowHeight = 30;
            var ImagePaneSize = "270px";
            
            BrowserDimensions returnThis = new()
            {
                Width = Width,
                Height = Height,
                GridHeight = GridHeight,
                GridWidth = GridWidth,
                PageSize = PageSize,
                GalleryPageSize = GalleryPageSize,
                RowHeight = RowHeight,
                GalleryHeight = GalleryHeight,
                GalleryWidth = GalleryWidth,
                InnerGalleryHeight = InnerGalleryHeight,
                InnerGalleryWidth = InnerGalleryWidth,
                SplitterOrientation = SplitterOrientation,
                ImagePaneSize = ImagePaneSize,
                ColSpan = colSpan,
                GridOrGallery = gridOrGallery,
                ImageSize = imageSize,
                ImageContainerSize = imagerContainerSize
            };

            return returnThis;
        }
    }
}
