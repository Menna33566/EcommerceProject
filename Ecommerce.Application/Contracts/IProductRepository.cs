using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Models;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts
{
    public interface IProductRepository : IGenaricRepository<Product>
    {
        public IQueryable<Product> Search(string keyword);
        public List<Product> GetAllProudcts();
    }
}
