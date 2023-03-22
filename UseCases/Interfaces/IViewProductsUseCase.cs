using Models;

namespace UseCases.Interfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}