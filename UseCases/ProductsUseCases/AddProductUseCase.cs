using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.ProductsUseCases
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository _productRepository;

        public AddProductUseCase(IProductRepository productRepository)

        {
            _productRepository = productRepository;
        }

        public void Execute(Product product)
        {
            _productRepository.AddProduct(product);
        }
    }
}
