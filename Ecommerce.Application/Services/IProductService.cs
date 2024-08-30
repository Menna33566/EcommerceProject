using Ecommerce.DTOs.Product;
using System;
using System.Collections.Generic;
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

    }
}
