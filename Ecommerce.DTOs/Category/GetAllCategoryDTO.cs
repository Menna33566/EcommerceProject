using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTOs.Category
{
    public record GetAllCategoryDTO
    {
        public int Id { get; init; }
        public string CategoryName { get; init; }
    }
}
