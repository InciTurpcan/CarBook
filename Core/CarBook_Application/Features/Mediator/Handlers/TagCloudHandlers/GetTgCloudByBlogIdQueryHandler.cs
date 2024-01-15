﻿using CarBook_Application.Features.Mediator.Queries.TagCloudQueries;
using CarBook_Application.Features.Mediator.Results.TagCloudResults;
using CarBook_Application.Interfaces.TagCloudInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTgCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        private readonly ITagCloudRepository _repository;

        public GetTgCloudByBlogIdQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetTagCloudsByBlogId(request.Id);
            return values.Select(x=> new GetTagCloudByBlogIdQueryResult
            {
                Title = x.Title,
                TagCloudID = x.TagCloudID,
                BlogID=x.BlogID,
            }).ToList();
        }
    }
}
