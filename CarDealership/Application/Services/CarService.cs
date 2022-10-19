using Application.Interfaces;
using Application.Requests;
using Domain.Entities;

namespace Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository repository;
        private readonly ICarValidator validator;

        public CarService(ICarRepository repository, ICarValidator validator)
        {
            this.repository = repository;
            this.validator = validator;
        }

        public Guid Add(AddCarRequest request)
        {
            if (!validator.IsValid(request))
            {
                throw new ArgumentException("Invalid request");
            }

            var car = new Car
            {
                Id = Guid.NewGuid(),
                Marke = request.Marke,
                Model = request.Model,
                ProductionYear = request.ProductionYear,
                IsSold = false
            };

            repository.Add(car);

            return car.Id;
        }
    }
}
