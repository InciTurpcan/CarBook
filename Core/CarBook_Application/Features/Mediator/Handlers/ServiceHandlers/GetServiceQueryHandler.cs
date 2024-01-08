using CarBook_Application.Features.Mediator.Queries.ServiceQueries;
using CarBook_Application.Features.Mediator.Results.ServiceResults;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetSeviceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetSeviceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return  values.Select(x=> new GetServiceQueryResult
            {
                Description = x.Description,
                Title = x.Title,
                IconUrl = x.IconUrl,
                ServiceID = x.ServiceID
            }).ToList();
        }
    }
}
