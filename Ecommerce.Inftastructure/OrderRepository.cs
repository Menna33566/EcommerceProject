using Ecommerce.Application.Contracts;
using Ecommerce.Context;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Inftastructure
{
    public class OrderRepository : IOrderRepository
    {
        private readonly EcommerceDB _context;

        public OrderRepository(EcommerceDB context)
        {
            _context = context;
        }

        public Order GetById(int orderId)
        {
            return _context.Orders
                .Include(o => o.User)
                .Include(o => o.Product)
                .FirstOrDefault(o => o.OrderId == orderId);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(o => o.User)
                .Include(o => o.Product)
                .ToList();
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void Delete(int orderId)
        {
            var order = GetById(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public BindingList<Order> GetAllLocal()
        {
            _context.Orders.Load();
            return _context.Orders.Local.ToBindingList();
        }
    }
}
