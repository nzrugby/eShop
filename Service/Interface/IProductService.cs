using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetCategoryProducts(string Category);
        Product GetProduct(Guid id);
        void DeleteProduct(Guid id);
        void UpdateProduct(Product product);
        void AddProduct(Product product);
    }
}
