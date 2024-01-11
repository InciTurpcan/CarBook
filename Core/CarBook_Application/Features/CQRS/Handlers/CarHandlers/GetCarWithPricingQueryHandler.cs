using CarBook_Application.Features.CQRS.Results.CarResults;
using CarBook_Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithPricingQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithPricingQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithPricingsQueryResult> Handle()
        {
            var values = _repository.GetCarsWithPricings();
            return values.Select(x => new GetCarWithPricingsQueryResult
            {
               Model=x.Car.Model,
               CoverImgUrl=x.Car.CoverImgUrl,
               BrandName=x.Car.Brand.Name,
               PricingAmount=x.Amount
            }).ToList();
        }

    }
}
