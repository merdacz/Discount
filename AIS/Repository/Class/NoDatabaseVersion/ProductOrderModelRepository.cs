using AIS.Models;
using AIS.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Repository.Class.NoDatabaseVersion
{
    public class ProductOrderModelRepository : Repository<ProductOrderModel>, IProductOrderModelRepository
    {
        public ProductOrderModelRepository() : base(new List<ProductOrderModel>())
        {

        }
    }
}
