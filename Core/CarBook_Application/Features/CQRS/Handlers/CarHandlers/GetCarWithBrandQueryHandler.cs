using CarBook_Application.Features.CQRS.Results.CarResults;
using CarBook_Application.Interfaces;
using CarBook_Application.Interfaces.CarInterfaces;
using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values =  _repository.GetCarListWithBrands();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                BrandName=x.Brand.Name,
                CarID = x.CarID,
                BrandID = x.BrandID,
                BigImgUrl = x.BigImgUrl,
                CoverImgUrl = x.CoverImgUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission

            }).ToList();
        }
    }
}
