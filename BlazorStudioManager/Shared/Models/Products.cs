using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.Models
{
    public class Products
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
        public bool ActiveSelling =>
            SellStartDate < DateTime.UtcNow && (!SellEndDate.HasValue || SellEndDate > DateTime.UtcNow);

        public Products()
        {
        }

        public static List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            var product = new Products()
            {
                ProductId = 713,
                Name = "Long-Sleeve Logo Jersey, S",
                ProductNumber = "LJ-0192-S",
                Color = "Multi",
                Size = "S",
                Weight = null,
                ProductCategoryId = 25,
                SellEndDate = null,
                DiscontinuedDate = null,
                ThumbnailPhotoFileName = "awc_jersey_male_small.gif",
                ProductCategoryName = "Jerseys"
            };
            products.Add(product);
            return products;
            //using (StreamReader r = new StreamReader("products.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<Products> products = JsonConvert.DeserializeObject<List<Products>>(json);
            //    return products;
            //}
        }
    }
}
