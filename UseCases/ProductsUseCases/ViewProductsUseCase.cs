using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.ProductsUseCases
{
    public class ViewProductsUseCase : IViewProductsUseCase
    {
        public readonly IProductRepository _productRepository;
        public ViewProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public IEnumerable<Product> Execute()
        {
            return _productRepository.GetProducts();
        }
    }
}
