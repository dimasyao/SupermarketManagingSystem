using Models;

namespace UseCases.Interfaces
{
    public interface IViewProductByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}