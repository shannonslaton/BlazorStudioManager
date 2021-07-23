using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.ReportModels
{
    public class ZProduct
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public decimal? Weight { get; set; }
        public int? ProductCategoryId { get; set; }
        public DateTime SellStartDate { get; set; } = DateTime.Today;
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ProductCategoryName { get; set; }
        //public bool ActiveSelling =>
        //    SellStartDate < DateTime.UtcNow && (!SellEndDate.HasValue || SellEndDate > DateTime.UtcNow);
    }
}
