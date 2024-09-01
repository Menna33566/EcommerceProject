using Ecommerce.DTOs.Product;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public interface IProductService
    {
        public CreateProductDTO AddProduct(CreateProductDTO addproduct);
        public CreateProductDTO UpdateProduct(CreateProductDTO updateprodct);
        public void DeleteProduct(DeleteProductDTO deleteproduct);
        public List<GetAllProductDTO> GetAllProudctPagination(int count, int pagenumber);
        public List<GetAllProductDTO> SearchProduct(string productname);
        public BindingList<Product> GetAllProductBinding();
        public void savechanges();

        public List<Product> GetAllProudcts();
        public List<GetAllProductDTO> FilterByCategory(string CategoryName, int Count, int PageNumber);
       // public ProductDetailsDTO GetProductDetails(GetAllProductsDTO Product);

        public List<GetAllProductDTO> SearchProduct(string productname,int count, int pageNum);

    }
}
