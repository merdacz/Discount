using AIS.Models;
using AIS.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Repository.Class.NoDatabaseVersion
{
    public class DiscountRepository: Repository<DiscountModel>,IDiscountRepository
    {
        public DiscountRepository()
            : base(new List<DiscountModel>
                {
                    new DiscountModel
                    {
                        DiscountInPercent = 10.0m,
                        DiscountType = DiscountType.WholeOrder,
                        MinQuantity = 10,
                        Product = null
                    },
                    new DiscountModel
                    {
                        DiscountInPercent = 5.0m,
                        DiscountType = DiscountType.Individual,
                        MinQuantity = 5,
                        ID = Guid.NewGuid().ToString()

                    },
                    new DiscountModel
                    {
                        ID = Guid.NewGuid().ToString(),
                        MinQuantity = 0,
                        DiscountType = DiscountType.None,
                        DiscountInPercent = 0.0m,
                        Product = null
                    }
                })
        {

        }
    }
}
