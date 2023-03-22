using Models;

namespace UseCases.Interfaces
{
    public interface IGetCategoryById
    {
        Category Execute(int id);
    }
}