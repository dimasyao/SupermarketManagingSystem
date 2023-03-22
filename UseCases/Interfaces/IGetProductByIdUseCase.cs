using Models;

namespace UseCases.Interfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int id);
    }
}