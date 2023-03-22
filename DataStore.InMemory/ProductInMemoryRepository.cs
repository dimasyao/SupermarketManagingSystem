using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductInMemoryRepository()
        {
            _products = new List<Product>()
            {
                new Product() { Id = 1, CategoryId = 1, Name = "Kurka", Price = 10, Quantity = 4},
                new Product() { Id = 2, CategoryId = 3, Name = "Persik", Price = 4, Quantity = 2},
                new Product() { Id = 3, CategoryId = 2, Name = "Kartosha", Price = 11, Quantity = 100},
                new Product() { Id = 4, CategoryId = 2, Name = "Burak", Price = 10, Quantity = 5},
                new Product() { Id = 5, CategoryId = 3, Name = "Yablyko", Price = 15, Quantity = 6},
                new Product() { Id = 6, CategoryId = 1, Name = "Svinya", Price = 11, Quantity = 7},
            };
        }

        public void AddProduct(Product product)
        {
            if (!_products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
            {
                if (_products != null && _products.Count != 0)
                {
                    var maxId = _products.Max(x => x.Id);
                    product.Id = maxId + 1;
                }
                else
                {
                    product.Id = 1;
                }

                _products.Add(product);
            }
        }

        public void EditProduct(Product product)
        {
            var editedProduct = GetProductById(product.Id);

            if( editedProduct != null)
            {
                editedProduct.Name = product.Name;
                editedProduct.CategoryId = product.CategoryId;
                editedProduct.Price = product.Price;
                editedProduct.Quantity = product.Quantity;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteProductById(int id)
        {
            var product = GetProductById(id);

            if(product != null) _products.Remove(product);
        }

        public IEnumerable<Product> ViewProductByCategoryId(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId);
        }
    }
}
