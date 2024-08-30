using Ecommerce.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public interface IUserService
    {
        UserDto AddUser(UserDto userDto);
        UserDto UpdateUser(UserDto userDto);
        UserDto GetUserById(int userId);
        IQueryable<UserDto> GetAllUsers();
        void DeleteUser(int userId);
    }
}
