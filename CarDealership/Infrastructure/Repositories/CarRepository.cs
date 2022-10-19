using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Car> cars = new();

        public Guid Add(Car car)
        {
            cars.Add(car);

            return car.Id;
        }
    }
}
