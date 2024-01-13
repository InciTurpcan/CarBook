using CarBook_Application.Features.Mediator.Queries.BlogQueries;
using CarBook_Application.Features.Mediator.Results.BlogResults;
using CarBook_Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorsQueryHandler : IRequestHandler<GetAllBlogsWithAuthorsQuery, List<GetAllBlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetAllBlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllBlogsWithAuthors();
            return values.Select(x => new GetAllBlogsWithAuthorQueryResult
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                AuthorName=x.Author.Name,
                CategoryID = x.CategoryID,
                CoverImgUrl=x.CoverImgUrl,
                CreateDate = x.CreateDate,
                Title = x.Title,
                Description= x.Description,
            }).ToList();
        }
    }
}
