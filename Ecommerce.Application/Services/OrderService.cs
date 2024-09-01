using AutoMapper;
using Ecommerce.Application.Contracts;
using Ecommerce.DTOs.Order;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public IEnumerable<OrderDto> GetOrdersByUserAndStatus(int userId, string status)
        {
            var orders = _orderRepository.GetOrdersByUserAndStatus(userId, status);
            return _mapper.Map<IEnumerable<OrderDto>>(orders);
        }

        public void UpdateOrderStatus(int orderId, string status)
        {
            _orderRepository.UpdateStatus(orderId, status);
        }

        public void UpdateOrderQuantity(int orderId, int quantity)
        {
            _orderRepository.UpdateQuantity(orderId, quantity);
        }

        public void DeleteOrder(int orderId)
        {
            var order = _orderRepository.GetById(orderId);
            if (order != null)
            {
                _orderRepository.Delete(order);
            }
        }

        public List<ordersPending> getAllPendingOrders(int user_id, string stat)
        {
            return _orderRepository.GetAllPending(user_id, stat);
        }

        void IOrderService.CreateOrder(OrderDto orderDto)
        {
            throw new NotImplementedException();
        }
    }

}
