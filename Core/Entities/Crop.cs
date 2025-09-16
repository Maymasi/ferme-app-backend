using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Crop
    {
        public string id { get; set; }
        public string name { get; set; }
        public string harvestYear { get; set; }
        public decimal harvestedQuantity { get; set; }
        public decimal unitSellingPrice { get; set; }
        public decimal totalRevenue {  get; set; }
        public string farmId { get; set; }
        public Farm farm {  get; set; }

    }
}
