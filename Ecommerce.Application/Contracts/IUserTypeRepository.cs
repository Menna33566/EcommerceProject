using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Models;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts
{
    public interface IUserTypeRepository
    {
        UserType GetById(int userTypeId);
        IEnumerable<UserType> GetAll();
        public void Save();

    }
}
