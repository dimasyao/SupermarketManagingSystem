using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public void AddProduct(Product product);
        public void EditProduct(Product product);
        public Product GetProductById(int id);
        public void DeleteProductById(int id);
        public IEnumerable<Product> ViewProductByCategoryId(int categoryId);
    }
}
