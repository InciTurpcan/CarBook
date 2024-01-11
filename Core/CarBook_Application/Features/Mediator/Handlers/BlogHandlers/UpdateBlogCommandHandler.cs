using CarBook_Application.Features.Mediator.Commands.BlogCommands;
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
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BlogID);
            value.Title = request.Title;
            value.CreateDate = request.CreateDate;
            value.CoverImgUrl = request.CoverImgUrl;
            value.AuthorID = request.AuthorID;
            value.CategoryID = request.CategoryID;
            await _repository.UpdateAsync(value);
        }
    }
}
