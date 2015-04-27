using AIS.Repository.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Repository.Class.NoDatabaseVersion
{
    public class OrderRepository : Repository<OrderModel>,IOrderRepository
    {
        public OrderRepository():base(new List<OrderModel>())
        {

        }
    }
}
