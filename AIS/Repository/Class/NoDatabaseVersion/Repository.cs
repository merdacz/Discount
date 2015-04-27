using AIS.Models;
using AIS.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Repository.Class.NoDatabaseVersion
{
    public class Repository<T> : IRepository<T> where T:BaseModel
    {
        private List<T> Context;
        public Repository(List<T> Context)
        {
            this.Context = Context;
        }
        public IQueryable<T> GetAll
        {
            get { return Context.AsQueryable(); }
        }

        public void Insert(T ModelInstance)
        {
            if(InstanceExists(ModelInstance))
            {
                Context.Add(ModelInstance);
                return;
            }
            Exception ex = new Exception("Object Exits");
            ex.Data.Add("ObjectId", ModelInstance.ID);
            throw ex;
        }
        public void Update(string ID, T UpdatedInstance)
        {
            T Instance = GetInstance(ID);
            if(Instance == null)
            {
                Exception ex = new Exception("Object does't exists");
                ex.Data.Add("ObjectId", UpdatedInstance.ID);
                throw ex;
            }
            Context.Remove(Instance);
            Context.Add(UpdatedInstance);
        }

        public void Delete(string ID)
        {
            T Instance = GetInstance(ID);
            if (Instance == null)
            {
                Exception ex = new Exception("Object does't exists");
                ex.Data.Add("ObjectId",ID);
                throw ex;
            }
            Context.Remove(Instance);
        }
        private bool InstanceExists(T ModelInstance)
        {
            return Context.Count(Instance=>Instance.ID == ModelInstance.ID) == 0;
        }

        private T GetInstance(String ID)
        {
            return Context.Find(Instance => Instance.ID == ID);

        }

    }
}
