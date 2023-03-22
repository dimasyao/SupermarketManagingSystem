using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAll();
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);
        public Category GetCategoryById(int id);
        public void DeleteCategoryById(int id);
    }
}
