using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Ecommerce.Models;
using Ecommerce.DTOs.Category;
using Ecommerce.DTOs.Order;
using Ecommerce.DTOs.Product;
using Ecommerce.DTOs.User;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ecommerce.Application.AutoMapper
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateCategoryDTO, Category>().ReverseMap();
            CreateMap<GetAllCategoryDTO, Category>().ReverseMap();
            //product
            CreateMap<CreateProductDTO, Product>().ReverseMap();
            CreateMap<DeleteProductDTO, Product>().ReverseMap();
            CreateMap<GetAllProductDTO, Product>().ReverseMap();
            //Order
            CreateMap<Order, OrderDto>().ReverseMap();
        }
    }
}
