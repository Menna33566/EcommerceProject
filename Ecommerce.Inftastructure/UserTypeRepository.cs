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
    public class UserTypeRepository : IUserTypeRepository
    {
        private readonly EcommerceDB context;
        public UserTypeRepository(EcommerceDB _context)
        {
            context = _context;
        }
        public IEnumerable<UserType> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserType GetById(int userTypeId)
        {
            return context.UserTypes.Where(u => u.Id == userTypeId).First();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
