using CarBook_Application.Features.CQRS.Commands.ContactCommands;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = command.Name,
                Email = command.Email,
                Message = command.Message,
                Subject = command.Subject,
                SendDate = command.SendDate
                
            });
        }
    }
}
