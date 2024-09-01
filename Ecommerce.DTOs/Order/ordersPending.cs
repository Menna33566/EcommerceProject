using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTOs.Order
{
    public class ordersPending
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string ProductName { get; set; }
    }
}
