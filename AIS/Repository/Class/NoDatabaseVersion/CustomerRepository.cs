using AIS.Repository.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Repository.Class.NoDatabaseVersion
{
    public class CustomerRepository : Repository<CustomerModel>,ICustomerRepository
    {
        public CustomerRepository():base( 
            new List<CustomerModel>
            {
                new CustomerModel
                {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Lukasz",
                    LastName = "Szulc",
                },
                new CustomerModel
                {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Adam",
                    LastName = "Nowak",
                },
                new CustomerModel
                {
                    ID  = Guid.NewGuid().ToString(),
                    FirstName = "Jan",
                    LastName = "Kowalski",
                }   
            })
        {

        }
    }
}
