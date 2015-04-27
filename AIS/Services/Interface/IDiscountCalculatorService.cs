using AIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Services.Interface
{
    public interface IDiscountCalculatorService
    {
        decimal Calculate(List<ProductOrderModel> Products);
    }
}
