using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.ProductsUseCases
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return _productRepository.GetProductById(id);
        }
    }
}
