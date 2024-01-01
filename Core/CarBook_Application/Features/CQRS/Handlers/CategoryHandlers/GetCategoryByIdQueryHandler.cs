using CarBook_Application.Features.CQRS.Queries.BrandQueries;
using CarBook_Application.Features.CQRS.Queries.CategoryQueries;
using CarBook_Application.Features.CQRS.Results.BrandResults;
using CarBook_Application.Features.CQRS.Results.CategoryResults;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = value.CategoryID,
                Name = value.Name
            };
        }
    }
}
