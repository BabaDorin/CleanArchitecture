using Application.Interfaces;
using Application.Requests;

namespace Application.Services
{
    public class CarValidator : ICarValidator
    {
        public bool IsValid(AddCarRequest request)
        {
            return !string.IsNullOrEmpty(request.Marke)
                && !string.IsNullOrEmpty(request.Model)
                && request.ProductionYear > 0
                && request.ProductionYear <= DateTimeOffset.UtcNow.Year;
        }
    }
}
