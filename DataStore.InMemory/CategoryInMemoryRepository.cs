using Models;
using UseCases.Interfaces;

namespace DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> _categories;

        public CategoryInMemoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Meat", Description = "Delishes"},
                new Category { Id = 2, Name = "Vegetables", Description = "Fresh"},
                new Category { Id = 3, Name = "Fruit", Description = "Colorful"},
            };
        }

        public void AddCategory(Category category)
        {
            if (!_categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))
            {
                if (_categories != null && _categories.Count != 0)
                {
                    var maxId = _categories.Max(x => x.Id);
                    category.Id = maxId + 1;
                }
                else
                {
                    category.Id = 1;
                }

                _categories.Add(category);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _categories;
        }

        public void UpdateCategory(Category category)
        {
            var updateCategory = GetCategoryById(category.Id);
            
            if (updateCategory != null)
            {
                updateCategory.Name = category.Name;
                updateCategory.Description = category.Description;
            }
        }

        public Category GetCategoryById(int id)
        {
            return _categories?.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteCategoryById(int id)
        {
            var category = GetCategoryById(id);

            if(category != null) _categories.Remove(category);
        }
    }
}