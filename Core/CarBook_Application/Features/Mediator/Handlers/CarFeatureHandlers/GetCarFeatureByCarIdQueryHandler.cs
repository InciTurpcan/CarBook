using CarBook_Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBook_Application.Features.Mediator.Results.CarFeatureResults;
using CarBook_Application.Features.Mediator.Results.LocationResults;
using CarBook_Application.Interfaces;
using CarBook_Application.Interfaces.CarFeatureInterfaces;
using CarBook_Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
    {
        private readonly ICarFeatureRepository _repository;

        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarFeaturesByCarId(request.Id);
            return values.Select(x => new GetCarFeatureByCarIdQueryResult
            {
               Available=x.Available,
               CarFeatureID=x.CarFeatureID,
               FeatureID=x.FeatureID,
               FeatureName=x.Feature.Name,
              
            }).ToList();
        }
    }
}
