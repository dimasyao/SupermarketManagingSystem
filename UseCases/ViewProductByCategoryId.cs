using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases
{
    public class ViewProductByCategoryId : IViewProductByCategoryId
    {
        private readonly IProductRepository _productRepository;

        public ViewProductByCategoryId(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(int categoryId)
        {
            return _productRepository.ViewProductByCategoryId(categoryId);
        }

    }
}
