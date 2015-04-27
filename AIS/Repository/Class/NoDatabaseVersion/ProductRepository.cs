using AIS.Models;
using AIS.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Repository.Class.NoDatabaseVersion
{
    public class ProductRepository : Repository<ProductModel>,IProductRepository
    {
        public ProductRepository()
            : base(new List<ProductModel> 
            { 
                new ProductModel
                {
                    ID = Guid.NewGuid().ToString(),
                    Discount = null,
                    Name = "Mug",
                    UnitPrice = 13.99M 
                    
                },
                new ProductModel
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "Book",
                    Discount = null,
                    UnitPrice = 35.95M
                    
                }
            })
        {

        }
    }
}
