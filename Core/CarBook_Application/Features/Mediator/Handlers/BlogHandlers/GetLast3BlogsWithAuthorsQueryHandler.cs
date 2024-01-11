using CarBook_Application.Features.CQRS.Results.CarResults;
using CarBook_Application.Features.Mediator.Queries.BlogQueries;
using CarBook_Application.Features.Mediator.Results.BlogResults;
using CarBook_Application.Interfaces;
using CarBook_Application.Interfaces.BlogInterfaces;
using CarBook_Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {
       private readonly IBlogRepository _repository;

        public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                CategoryID = x.CategoryID,
                CoverImgUrl = x.CoverImgUrl,
                Title = x.Title,
                CreateDate = x.CreateDate,
                AuthorName = x.Author.Name
            }).ToList();
        }
    }
}
