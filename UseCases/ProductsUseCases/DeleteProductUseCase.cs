using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.ProductsUseCases
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Execute(int id)
        {
            _productRepository.DeleteProductById(id);
        }

    }
}
