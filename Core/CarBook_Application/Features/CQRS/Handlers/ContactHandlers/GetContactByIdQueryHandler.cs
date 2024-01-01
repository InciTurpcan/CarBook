using CarBook_Application.Features.CQRS.Queries.ContactQueries;
using CarBook_Application.Features.CQRS.Results.ContactResults;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                ContactID = value.ContactID,
                Name = value.Name,
                Email = value.Email,
                Subject = value.Subject,
                Message = value.Message,
                SendDate = value.SendDate
            };
        }
    }
}
