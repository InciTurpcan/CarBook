using CarBook_Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook_Application.Features.Mediator.Results.StatisticsResults;
using CarBook_Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByElectricQueryHandler : IRequestHandler<GetCarCountByElectricQuery, GetCarCountByElectricQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByElectricQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarCountByElectricQueryResult> Handle(GetCarCountByElectricQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmSmallerThen1000();
            return new GetCarCountByElectricQueryResult
            {
                CarCountByElectric = value,
            };
        }
    }

}
