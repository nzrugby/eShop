using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Repo;

namespace Service.Implementation
{
    public class ProductService : IProductService
    {
        private IRepository<Product> repo;
        public ProductService(IRepository<Product> repo)
        {
            this.repo = repo;
        }

        public void AddProduct(Product product)
        {
            repo.Add(product);
        }

        public void DeleteProduct(Guid Id)
        {
            var product = repo.Get(Id);
            if (product == null)
            {
                throw new Exception("product doesn't exist");
            }
            repo.Remove(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return repo.GetAll();
        }

        public IEnumerable<Product> GetCategoryProducts(string Category)
        {
            return repo.GetAll().Where(p => p.Category == Category);
        }

        public Product GetProduct(Guid Id)
        {
            return repo.Get(Id);
        }

        public void UpdateProduct(Product product)
        {
            repo.Update(product);
        }
    }
}
