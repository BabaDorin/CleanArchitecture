using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICarRepository
    {
        Guid Add(Car car);
    }
}
