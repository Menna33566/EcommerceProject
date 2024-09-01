using Ecommerce.DTOs.User;
using Ecommerce.Models;
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
        public void changeuserActive();
        public bool CheckLogin(string email, string password);
        public int CheckUserType(string email, string password);
        public string AdminName();
        public void savechanges();

        //Nourhan added
        UserDto GetActiveUser();
    }
}
