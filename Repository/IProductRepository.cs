using AspNetCore5Microservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5Microservices.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void CreateProduct(Product Product);
        void DeleteProduct(int ProductId);
        void EditProduct(Product Product);
    }
}