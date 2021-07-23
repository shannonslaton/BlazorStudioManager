using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared.IdentityModels
{
    public class ZipCode
    {
        public int RecId { get; set; }
        public string Zip { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string TimeZone { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Latitude { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Longitude { get; set; }
        public string LatitudeSt { get; set; }
        public string LongitudeSt { get; set; }
        public string Country { get; set; }
    }
}
