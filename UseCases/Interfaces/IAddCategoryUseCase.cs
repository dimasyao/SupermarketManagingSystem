using Models;

namespace UseCases.Interfaces
{
    public interface IAddCategoryUseCase
    {
        void Execute(Category category);
    }
}