using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Models;
using System.Threading.Tasks;
using Ecommerce.DTOs.Order;

namespace Ecommerce.Application.Contracts
{
    public interface IOrderRepository
    {
        // Add a new order
        void Add(Order order);

        // Get orders by user ID and status
        IEnumerable<Order> GetOrdersByUserAndStatus(int userId, string status);

        // Get a specific order by its ID
        Order GetById(int orderId);

        // Update an existing order
        public void UpdateStatus(int orderId, string newStatus);
        public void UpdateQuantity(int orderId, int newQuantity);

        // Delete an order
        void Delete(Order order);
        public List<ordersPending> GetAllPending(int user_id, string stat);

        // Save changes to the database
        void SaveChanges();
    }
}
