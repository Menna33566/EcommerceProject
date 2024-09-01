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
            context.SaveChanges();

        }

        public void Delete(int userId)
        {
            User user;
            user = GetById(userId);
            context.Users.Remove(user);
            context.SaveChanges();
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
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void ChangeActiv()
        {
            context.Database.ExecuteSql($"UPDATE Users SET IsActive=0");
        }

        public bool LoginCheck(string password, string email)
        {
            if(context.Users.Any(u=>u.Email==email&& u.Password == password))
            {
                var user = context.Users
                    .Where(u => u.Email == email && u.Password == password)
                    .FirstOrDefault();

                if (user != null)
        {
                    user.IsActive = true;
                    context.SaveChanges();
                }
                return true;
            }
            return false;
        }

        public int checkType(string password, string email)
        {
            var user = context.Users
                    .Where(u => u.Email == email && u.Password == password)
                    .Select(p=>p.UserTypeId).ToList();
            //if (user != null)
            //{
            //    return user.UserType.Id;
            //}
            return user[0];
        }

        public string NameofAdmin()
        {
            var user =context.Users.Where(p=>p.IsActive==true).Select(p=>p.UserName).ToList();
            return user[0];
        }
        // implement it
        public User GetActiveUser()
        {
            throw new NotImplementedException();
        }
    }
}
