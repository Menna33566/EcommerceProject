using Ecommerce.Application.Contracts;
using Ecommerce.Context;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Inftastructure
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EcommerceDB context;
        public CategoryRepository(EcommerceDB _context)
        {

            context = _context;

        }
        public Category Add(Category entity)
        {
            return context.Categories.Add(entity).Entity;
        }

        public void Delete(Category entity)
        {
            context.Categories.Remove(entity);
        }
        //CREATE PROCEDURE DeleteCategory
        //    @Id INT
        //AS
        //BEGIN
        //    DELETE FROM Category
        //    WHERE Id = @Id;
        //END
        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public Category Update(Category entity)
        {
            context.Categories.FromSql($"EXEC UpdateCategory @Id = {entity.Id}, @CategoryName = {entity.CategoryName}");
            Category cat = context.Categories.Where(c => c.Id == entity.Id).First();
            return cat;
        }
        //        CREATE PROCEDURE UpdateCategory
        //    @Id INT,
        //    @CategoryName NVARCHAR(100)
        //AS
        //BEGIN
        //    UPDATE[YourTableName]
        //    SET CategoryName = @CategoryName
        //    WHERE Id = @Id;
        //END
    }
}
