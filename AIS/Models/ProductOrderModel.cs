using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Models
{
    public class ProductOrderModel : BaseModel
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public OrderModel Order { get; set; }
        public DiscountType DiscountType { get; set; }
        public decimal DiscountPercent { get; set; }
        public String OrderID { get; set; }
    }
}
