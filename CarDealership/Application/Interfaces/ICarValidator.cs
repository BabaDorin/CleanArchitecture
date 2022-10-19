using Application.Requests;

namespace Application.Interfaces
{
    public interface ICarValidator
    {
        bool IsValid(AddCarRequest request);
    }
}
