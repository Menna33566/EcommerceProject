using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts
{
    public interface IGenaricRepository<T> where T : class
    {
        public T Add(T entity);
        public T Update(T entity);
        public void Delete(T entity);
        public IQueryable<T> GetAll();
        public void Save();
        public BindingList<T> GetAllLocal();
        //public T Getone(int EntityId);
    }
}
