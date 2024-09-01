using Ecommerce.Application.Contracts;
using Ecommerce.Context;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Inftastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly EcommerceDB _context;

        public UserRepository(EcommerceDB context)
        {
            _context = context;
        }

        // Function to get the active user
        public User GetActiveUser()
        {
            return _context.Users.FirstOrDefault(u => u.IsActive == true);
        }

        void IUserRepository.Add(User user)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Delete(int userId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<User> IUserRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetById(int userId)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
