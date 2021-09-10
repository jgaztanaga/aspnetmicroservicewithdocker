using AspNetCore5Microservices.DataContexts;
using AspNetCore5Microservices.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5Microservices.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public Product GetProductByID(int productId)
        {
            return _dbContext.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _dbContext.Products.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void CreateProduct(Product product)
        {
            _dbContext.Add(product);
            _dbContext.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}