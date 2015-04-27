using AIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class CustomerModel : BaseModel
    {

        public CustomerModel()
        {
            Orders = new List<OrderModel>();
        }
        public String FirstName { get; set; }
        public String  LastName { get; set; }
        public List<OrderModel> Orders { get; set; }
    }
}
