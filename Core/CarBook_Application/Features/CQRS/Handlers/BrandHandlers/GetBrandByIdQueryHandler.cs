using CarBook_Application.Features.CQRS.Queries.BrandQueries;
using CarBook_Application.Features.CQRS.Results.AboutResults;
using CarBook_Application.Features.CQRS.Results.BrandResults;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandID = value.BrandID,
                Name = value.Name
            };
        }
    }
}
