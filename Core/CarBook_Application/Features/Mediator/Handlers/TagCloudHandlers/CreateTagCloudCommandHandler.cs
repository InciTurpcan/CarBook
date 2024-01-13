using CarBook_Application.Features.Mediator.Commands.TagCloudCommands;
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
    public class CreateTagCloudCommandHandler : IRequestHandler<CreateTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public CreateTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TagCloud
            {
                Title = request.Title,
                BlogID = request.BlogID,
            });
        }
    }
}
