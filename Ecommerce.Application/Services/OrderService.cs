using Ecommerce.Application.Contracts;
using Ecommerce.DTOs.Order;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderDto GetOrderById(int orderId)
        {
            var order = _orderRepository.GetById(orderId);
            if (order == null)
                throw new KeyNotFoundException("Order not found.");

            return new OrderDto
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                UserId = order.UserId,
                ProductId = order.ProductId,
                Quantity = order.Quantity,
                Status = order.Status
            };
        }

        public IEnumerable<OrderDto> GetAllOrders()
        {
            var orders = _orderRepository.GetAllOrders();
            return orders.Select(o => new OrderDto
            {
                OrderId = o.OrderId,
                OrderDate = o.OrderDate,
                UserId = o.UserId,
                ProductId = o.ProductId,
                Quantity = o.Quantity,
                Status = o.Status
            });
        }

        public void CreateOrder(OrderDto orderDto)
        {
            var order = new Order
            {
                OrderDate = orderDto.OrderDate,
                UserId = orderDto.UserId,
                ProductId = orderDto.ProductId,
                Quantity = orderDto.Quantity,
                Status = orderDto.Status
            };

            _orderRepository.Add(order);
        }

        public void UpdateOrderStatus(int orderId, string status)
        {
            var order = _orderRepository.GetById(orderId);
            if (order == null)
                throw new KeyNotFoundException("Order not found.");

            order.Status = status;
            _orderRepository.Update(order);
        }

        public void DeleteOrder(int orderId)
        {
            _orderRepository.Delete(orderId);
        }

        public void savechanges()
        {
            _orderRepository.Save();
        }

        public BindingList<Order> GetAllOrderBinding()
        {
            return _orderRepository.GetAllLocal();
        }
    }
}
