using CarBook_Application.Features.Mediator.Queries.BlogQueries;
using CarBook_Application.Features.Mediator.Results.AuthorResults;
using CarBook_Application.Features.Mediator.Results.BlogResults;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;
        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
               AuthorID=values.AuthorID,
               BlogID=values.BlogID,
               CategoryID=values.CategoryID,
               CoverImgUrl=values.CoverImgUrl,
               Title = values.Title,
               CreateDate = values.CreateDate,
            };
        }
    }
}
