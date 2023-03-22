using Models;

namespace UseCases.Interfaces
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}