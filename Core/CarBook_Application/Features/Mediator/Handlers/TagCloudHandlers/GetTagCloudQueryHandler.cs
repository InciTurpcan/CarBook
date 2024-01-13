using CarBook_Application.Features.Mediator.Queries.TagCloudQueries;
using CarBook_Application.Features.Mediator.Results.TagCloudResults;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudQueryHandler : IRequestHandler<GetTagCloudQuery, List<GetTagCloudQueryResult>>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudQueryResult>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetTagCloudQueryResult
            {
                BlogID = x.BlogID,
                TagCloudID = x.TagCloudID,
                Title= x.Title,
            }).ToList();
            
        }
    }
}
