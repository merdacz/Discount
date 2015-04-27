using AIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class OrderModel : BaseModel
    {
        public OrderModel()
        {
            Products = new List<ProductOrderModel>();
        }
        public DateTime Created { get; set; }
        public decimal Ammount { get; set; }
        public String CustomerID { get; set; }
        //Navigation Property
        public CustomerModel Customer { get; set; }
        public List<ProductOrderModel> Products { get; set; }

    }
}
