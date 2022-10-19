using Application.Requests;

namespace Application.Interfaces
{
    public interface ICarService
    {
        Guid Add(AddCarRequest request);
    }
}
