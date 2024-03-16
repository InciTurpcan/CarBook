using CarBook_Application.Features.Mediator.Queries.RentACarQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentACarController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetRentACarListByLocation(int LocationId,bool Avaiable)
        {
            GetRentACarQuery getRentACarQuery = new GetRentACarQuery()
            {
                LocationId = LocationId,
                Available = Avaiable
            };
            var values = await _mediator.Send(getRentACarQuery);  
            return Ok(values);  
        }
    }
}
