using Ecommerce.Application.Contracts;
using Ecommerce.Context;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Inftastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcommerceDB context;
        public ProductRepository(EcommerceDB _context)
        {
            context = _context;
        }
        public Product Add(Product entity)
        {
                Product prd= context.Products.Add(entity).Entity;
            context.SaveChanges();
            return prd;
        }

        public void Delete(Product entity)
        {
            context.Products.Remove(entity);
            context.SaveChanges();
        }

        public IQueryable<Product> GetAll()
        {
            return context.Products;
        }

        public IQueryable<Product> Search(string keyword)
        {
            return context.Products.FromSql($"SELECT * FROM Products WHERE ProductName LIKE {keyword}");
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public Product Update(Product entity)
        {
            context.Products.FromSql($"EXEC UpdateProduct \n    @Id = {entity.Id},\n    @ProductName = {entity.ProductName},\n    @Price = {entity.Price},\n    @ImageURL ={entity.ImageURL},\n    @Quantity ={entity.Quantity},\n    @ProductDescription ={entity.ProductDescription},\n    @CategoryId ={entity.CategoryId}");
            Product prdt = context.Products.Where(c => c.Id == entity.Id).First();
            context.SaveChanges();
            return prdt;
        }
        //        CREATE PROCEDURE UpdateProduct
        //    @Id INT,
        //    @ProductName NVARCHAR(100),
        //    @Price DECIMAL(18, 2),
        //    @ImageURL NVARCHAR(MAX),
        //    @Quantity INT,
        //    @ProductDescription NVARCHAR(MAX),
        //    @CategoryId INT
        //AS
        //BEGIN
        //    UPDATE[YourProductTableName]
        //    SET
        //        ProductName = @ProductName,
        //        Price = @Price,
        //        ImageURL = @ImageURL,
        //        Quantity = @Quantity,
        //        ProductDescription = @ProductDescription,
        //        CategoryId = @CategoryId
        //    WHERE Id = @Id;
        //END


        public BindingList<Product> GetAllLocal()
        {
            context.Products.Load();
            return context.Products.Local.ToBindingList();
        }
    }
}
