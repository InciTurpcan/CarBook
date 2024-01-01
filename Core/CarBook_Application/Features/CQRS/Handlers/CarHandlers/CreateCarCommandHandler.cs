using CarBook_Application.Features.CQRS.Commands.CarCommands;
using CarBook_Application.Interfaces;
using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImgUrl = command.BigImgUrl,
                Luggage=command.Luggage,
                Km=command.Km,
                Model=command.Model,
                Seat=command.Seat,
                Transmission=command.Transmission,
                CoverImgUrl=command.CoverImgUrl,
                BrandID=command.BarandID,
                Fuel=command.Fuel
            });
        }
    }
}
