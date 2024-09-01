using Ecommerce.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public interface IOrderService
    {
        // Create a new order
        void CreateOrder(OrderDto orderDto);

        // Get all orders by user and status
        IEnumerable<OrderDto> GetOrdersByUserAndStatus(int userId, string status);

        // Update the status of an order
        void UpdateOrderStatus(int orderId, string status);


        // Update the quantity of a specific order
        void UpdateOrderQuantity(int orderId, int quantity);
        public List<ordersPending> getAllPendingOrders(int user_id, string stat);

        // Delete an order
        void DeleteOrder(int orderId);
    }
}
