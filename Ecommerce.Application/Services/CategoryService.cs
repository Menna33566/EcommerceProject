using AutoMapper;
using Ecommerce.Application.Contracts;
using Ecommerce.DTOs.Category;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(ICategoryRepository _categoryRepository, IMapper _mapper)
        {
            categoryRepository = _categoryRepository;
            mapper = _mapper;
        }
        public CreateCategoryDTO AddCategory(CreateCategoryDTO addcategory)
        {
            Category category = mapper.Map<Category>(addcategory);
            if (category != null && category.CategoryName.Length >= 3)
            {
                Category cat = categoryRepository.Add(category);
                return mapper.Map<CreateCategoryDTO>(cat);
            }
            return null;
        }
        public CreateCategoryDTO UpdateCategory(CreateCategoryDTO updatecategory)
        {
            Category category = mapper.Map<Category>(updatecategory);
            if (category != null)
            {
                Category cat = categoryRepository.Update(category);
                return mapper.Map<CreateCategoryDTO>(cat);
            }
            return null;
        }
        public void DeleteCategory(GetAllCategoryDTO deletecategory)
        {
            Category category = mapper.Map<Category>(deletecategory);
            if (category != null)
            {
                categoryRepository.Delete(category);

            }
        }
        public List<GetAllCategoryDTO> GetAllCategory()
        {
            var categorydto = categoryRepository.GetAll().Select(c => new GetAllCategoryDTO
            {
                Id = c.Id,
                CategoryName = c.CategoryName
            }).ToList();
            return categorydto;
        }

        public void savechanges()
        {
            categoryRepository.Save();
        }

        public BindingList<Category> GetAllCategoryBinding()
        {
            return categoryRepository.GetAllLocal();
        }
    }
}
