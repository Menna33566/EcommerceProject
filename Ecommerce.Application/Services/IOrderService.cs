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
        OrderDto GetOrderById(int orderId);
        IEnumerable<OrderDto> GetAllOrders();
        void CreateOrder(OrderDto orderDto);
        void UpdateOrderStatus(int orderId, string status);
        void DeleteOrder(int orderId);
    }
}
