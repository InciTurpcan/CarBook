using CarBook_Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook_Application.Features.Mediator.Results.CarPricingResults;
using CarBook_Application.Interfaces;
using CarBook_Application.Interfaces.CarPricingInterfaces;
using CarBook_Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values =  _carPricingRepository.GetCarPricingWithCars();
            return values.Select(x=> new GetCarPricingWithCarQueryResult
            {
                Amount = x.Amount,
                Brand=x.Car.Brand.Name,
                CarPricingId=x.CarPricingID,
                CoverImageUrl=x.Car.CoverImgUrl,
                Model=x.Car.Model,
            }).ToList();
        }
    }
}
