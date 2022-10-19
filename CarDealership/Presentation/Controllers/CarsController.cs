using Application.Interfaces;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ICarService service;

        public CarsController(ICarService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult Create(AddCarRequest request)
        {
            var carId = service.Add(request);

            return Created(HttpContext.Request.Path, carId);
        }
    }
}