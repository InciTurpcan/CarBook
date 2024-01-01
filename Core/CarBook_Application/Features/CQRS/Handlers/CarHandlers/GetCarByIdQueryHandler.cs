using CarBook_Application.Features.CQRS.Queries.CarQueries;
using CarBook_Application.Features.CQRS.Results.CarResults;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandID=values.BrandID,
                BigImgUrl=values.BigImgUrl,
                CoverImgUrl=values.CoverImgUrl,
                Fuel=values.Fuel,
                CarID=values.CarID,
                Transmission=values.Transmission,
                Seat=values.Seat,
                Model=values.Model,
                Km=values.Km,
                Luggage=values.Luggage
            };
        }
    }
}
