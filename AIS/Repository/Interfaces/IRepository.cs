using AIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Repository.Interfaces
{
    /// <summary>
    /// Generic repository which support basic CRUD operations 
    /// </summary>
    /// <typeparam name="T">Specific repository Type ex. ProductModel</typeparam>
    public interface IRepository<T> where T: BaseModel
    {
        IQueryable<T> GetAll { get; }
        void Insert(T ModelInstance);
        void Update(String ID, T UpdatedInstance);
        void Delete(String ID);
    }
}
