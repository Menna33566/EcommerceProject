using Ecommerce.Application.Contracts;
using Ecommerce.Context;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Inftastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly EcommerceDB context;
        public UserRepository(EcommerceDB _context)
        {
            context = _context;
        }
        public void Add(User user)
        {
            context.Users.Add(user);
        }

        public void Delete(int userId)
        {
            User user;
            user = GetById(userId);
            context.Users.Remove(user);
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetById(int userId)
        {
            return context.Users.Where(u => u.Id == userId).First();
        }

        public void Update(User user)
        {
            context.Users.FromSql($"EXEC UpdateUser \n    @Id = {user.Id},\n    @UserName = {user.UserName},\n    @Email = {user.Email},\n    @Password = {user.Password},\n    @Address = {user.Address},\n    @UserTypeId = {user.UserType},\n    @IsActive = {user.IsActive}");
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
