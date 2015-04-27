using AIS.Models;
using AIS.Repository.Class.NoDatabaseVersion;
using AIS.Repository.Interfaces;
using AIS.Services.Class;
using AIS.Services.Interface;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS
{
    class Program
    {
        static List<ProductOrderModel> Cart = new List<ProductOrderModel>();
        static void Main(string[] args)
        {
            ICustomerRepository customerRepo = new CustomerRepository();
            IProductRepository productRepo = new ProductRepository();
            IOrderRepository ordersRepo = new OrderRepository();
            IDiscountRepository discountRepo = new DiscountRepository();
            IDiscountCalculatorService discountService = new DiscountCalculatorService();

            var product = productRepo.GetAll.First();
            
            var discounts = discountRepo.GetAll.ToList();
            product.Discount = discounts[1];
            addToStore(product, 10);
            addToStore(product, 5);
            addToStore(product, 15);
            Console.WriteLine(discountService.Calculate(Cart));
            Console.ReadKey();

        }

        static void addToStore(ProductModel product,int Quantity)
        {
            ProductOrderModel orderModel = new ProductOrderModel
            {
                ID = Guid.NewGuid().ToString(),
                Name = product.Name,
                Quantity = Quantity,
                Price = product.UnitPrice,
                DiscountType = DiscountType.None,
                DiscountPercent = 0.0m
            };
            if(product.Discount != null)
            {
                if (orderModel.Quantity >= product.Discount.MinQuantity && product.Discount.DiscountType != DiscountType.None)
                {
                    orderModel.DiscountPercent = product.Discount.DiscountInPercent;
                    orderModel.DiscountType = product.Discount.DiscountType;
                }
            }
            Cart.Add(orderModel);
        }

       
    }
}
