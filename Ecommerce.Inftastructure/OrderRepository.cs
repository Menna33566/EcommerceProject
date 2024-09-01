using Ecommerce.Application.Contracts;
using Ecommerce.Context;
using Ecommerce.DTOs.Order;
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

        // Add a new order to the database
        public void Add(Order order)
        {
            _context.Orders.Add(order);
            SaveChanges();
        }

        // Get orders for a specific user by status
        public IEnumerable<Order> GetOrdersByUserAndStatus(int userId, string status)
        {
            return _context.Orders
                           .Where(o => o.UserId == userId && o.Status == status)
                           .ToList();
        }

        // Get a specific order by its ID
        public Order GetById(int orderId)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == orderId);
        }

        // Update an existing order
        public void UpdateStatus(int orderId, string newStatus)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == orderId);
            order.Status = newStatus;
            SaveChanges();
        }
        public void UpdateQuantity(int orderId, int newQuantity)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == orderId);
            var product_id = order.ProductId;
            var product = _context.Products.FirstOrDefault(p => p.Id == product_id);
            
            var oldQuantity = order.Quantity;

            if(newQuantity < oldQuantity)
            {
                product.Quantity += (oldQuantity - newQuantity);
            }
            else
            {
                int diff = newQuantity - order.Quantity;
                diff = Math.Min(diff, product.Quantity);
                newQuantity = order.Quantity + diff;
                product.Quantity = 0;
            }
            order.Quantity = newQuantity;
            SaveChanges();
        }

        // Delete an order from the database
        public void Delete(Order order)
        {
            _context.Orders.Remove(order);
            SaveChanges();
        }


        //get the data for the OderForm
        public List<ordersPending> GetAllPending(int user_id, string stat) {
            var res = (from order in _context.Orders
                        join product in _context.Products
                        on order.ProductId equals product.Id
                        where order.Status == stat  &&  order.UserId == user_id
                        select new ordersPending
                        {
                           Id = order.Id,
                           Quantity = order.Quantity,
                           Status = order.Status,
                           Price = product.Price,
                           ImageURL = product.ImageURL,
                           ProductName = product.ProductName
                        }
                       ).ToList();

            return res;
        }

        // Save changes to the database
        public void SaveChanges()
        {
            _context.SaveChanges();
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

        public IQueryable<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }

        public void Delete(int orderId)
        {
            throw new NotImplementedException();
        }


    }
}
