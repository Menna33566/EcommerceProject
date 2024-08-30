using Ecommerce.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public interface ICategoryService
    {
        public CreateCategoryDTO AddCategory(CreateCategoryDTO addcategory);
        public CreateCategoryDTO UpdateCategory(CreateCategoryDTO updatecategory);
        public void DeleteCategory(GetAllCategoryDTO deletecategory);
        public List<GetAllCategoryDTO> GetAllCategory();


    }
}
