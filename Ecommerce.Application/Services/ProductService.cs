using AutoMapper;
using Ecommerce.Application.Contracts;
using Ecommerce.DTOs.Product;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository productRepository;
        private readonly IMapper mapper;
        public ProductService(IProductRepository _productRepository, IMapper _mapper)
        {
            productRepository = _productRepository;
            mapper = _mapper;
        }
        public CreateProductDTO AddProduct(CreateProductDTO addproduct)
        {
            Product product = mapper.Map<Product>(addproduct);
            if (product != null && product.Price > 20 && product.ImageURL != null)
            {
                Product prdct = productRepository.Add(product);
                return mapper.Map<CreateProductDTO>(prdct);
            }
            return null;
        }
        public CreateProductDTO UpdateProduct(CreateProductDTO updateprodct)
        {
            Product product = mapper.Map<Product>(updateprodct);
            if (product != null && product.Price > 20 && product.ImageURL != null)
            {
                Product prdct = productRepository.Update(product);
                return mapper.Map<CreateProductDTO>(prdct);
            }
            return null;
        }
        public void DeleteProduct(DeleteProductDTO deleteproduct)
        {
            Product product = mapper.Map<Product>(deleteproduct);
            if (product != null)
            {
                productRepository.Delete(product);
            }
        }
        public List<GetAllProductDTO> GetAllProudctPagination(int count, int pagenumber)
        {
            var productlist = productRepository.GetAll().Skip((pagenumber - 1) * count).Take(count)
                .Select(c => new GetAllProductDTO
                {
                    Id = c.Id,
                    ProductName = c.ProductName,
                    Price = c.Price,
                    ProductDescription = c.ProductDescription,
                    Quantity = c.Quantity,
                    ImageURL = c.ImageURL,
                    CategoryId = c.CategoryId
                }).ToList();
            return productlist;
        }
        public List<GetAllProductDTO> SearchProduct(string productname)
        {
            var searchlst = productRepository.Search(productname).Select(c => new GetAllProductDTO
            {
                Id = c.Id,
                ProductName = c.ProductName,
                Price = c.Price,
                ProductDescription = c.ProductDescription,
                Quantity = c.Quantity,
                ImageURL = c.ImageURL,
                CategoryId = c.CategoryId
            }).ToList();
            return searchlst;
        }
    }
}
