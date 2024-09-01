using Ecommerce.Application.Contracts;
using Ecommerce.DTOs.User;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserTypeRepository _userTypeRepository;

        public UserService(IUserRepository userRepository, IUserTypeRepository userTypeRepository)
        {
            _userRepository = userRepository;
            _userTypeRepository = userTypeRepository;
        }

        public UserDto AddUser(UserDto userDto)
        {
            var userType = _userTypeRepository.GetById(userDto.UserTypeId);
            if (userType == null)
            {
                throw new ArgumentException("Invalid UserTypeId");
            }

            var user = new User
            {
                UserName = userDto.UserName,
                Email = userDto.Email,
                Password = userDto.Password,
                Address = userDto.Address,
                UserTypeId = userDto.UserTypeId,
                IsActive = userDto.IsActive
            };

            _userRepository.Add(user);

            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                Address = user.Address,
                UserTypeId = user.UserTypeId,
                IsActive = user.IsActive
            };
        }

        public void changeuserActive()
        {
            _userRepository.ChangeActiv();
        }
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public bool CheckLogin(string email, string password)
        {
            if (Regex.IsMatch(email, emailPattern)&&password.Length>=6)
            {
                if (_userRepository.LoginCheck(password.Trim(), email.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteUser(int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            _userRepository.Delete(userId);
        }

        public IQueryable<UserDto> GetAllUsers()
        {
            return _userRepository.GetAll()
                .Select(user => new UserDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    Password = user.Password,
                    Address = user.Address,
                    UserTypeId = user.UserTypeId,
                    IsActive = user.IsActive
                }).AsQueryable();
        }

        public UserDto GetUserById(int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                Address = user.Address,
                UserTypeId = user.UserTypeId,
                IsActive = user.IsActive
            };
        }

        public void savechanges()
        {
            _userRepository.Save();
        }

        public UserDto UpdateUser(UserDto userDto)
        {
            var user = _userRepository.GetById(userDto.Id);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            var userType = _userTypeRepository.GetById(userDto.UserTypeId);
            if (userType == null)
            {
                throw new ArgumentException("Invalid UserTypeId");
            }

            user.UserName = userDto.UserName;
            user.Email = userDto.Email;
            user.Password = userDto.Password;
            user.Address = userDto.Address;
            user.UserTypeId = userDto.UserTypeId;
            user.IsActive = userDto.IsActive;

            _userRepository.Update(user);

            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                Address = user.Address,
                UserTypeId = user.UserTypeId,
                IsActive = user.IsActive
            };
        }

        public int CheckUserType(string email, string password)
        {
            return _userRepository.checkType(password,email);
        }

        public string AdminName()
        {
            return _userRepository.NameofAdmin();
        }
    }
}
