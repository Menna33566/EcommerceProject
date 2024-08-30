using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Models;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetById(int userId);
        void Update(User user);
        void Delete(int userId);
        IEnumerable<User> GetAll();
    }
}
