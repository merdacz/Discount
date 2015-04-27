using AIS.Models;
using AIS.Repository.Interfaces;
using AIS.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Services.Class
{
    public class DiscountCalculatorService : IDiscountCalculatorService
    {
        public decimal Calculate(List<ProductOrderModel> Products)
        {
            decimal sum = 0.0m;
            foreach (var product in Products)
            {
                switch (product.DiscountType)
                {
                    case DiscountType.WholeOrder:
                        break;
                    case DiscountType.Individual:
                        break;
                    case DiscountType.None:
                        break;
                    default:
                        break;

                }
            }
            return sum;
        }
    }
}
