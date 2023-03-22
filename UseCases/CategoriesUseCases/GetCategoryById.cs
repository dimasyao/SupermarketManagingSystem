using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.CategoriesUseCases
{
    public class GetCategoryById : IGetCategoryById
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoryById(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Execute(int id)
        {
            return _categoryRepository.GetCategoryById(id);
        }
    }
}
