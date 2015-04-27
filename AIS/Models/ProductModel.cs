using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Models
{
    public class ProductModel : BaseModel
    {
        public decimal UnitPrice { get; set; }
        public String Name { get; set; }
        public DiscountModel Discount { get; set; }
    }
}
