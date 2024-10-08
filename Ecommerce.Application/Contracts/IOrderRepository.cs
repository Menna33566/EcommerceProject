﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Models;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts
{
    public interface IOrderRepository
    {
        Order GetById(int orderId);
        IEnumerable<Order> GetAllOrders();
        void Add(Order order);
        void Update(Order order);
        void Delete(int orderId);
    }
}
