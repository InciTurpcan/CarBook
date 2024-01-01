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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID
                );
            values.Fuel = command.Fuel;
            values.Transmission = command.Transmission;
            values.BigImgUrl = command.BigImgUrl;
            values.BrandID = command.BrandID;
            values.CoverImgUrl = command.CoverImgUrl;
            values.Km=command.Km;
            values.Luggage = command.Luggage;
            values.Model = command.Model;
            values.Seat = command.Seat;
            await _repository.UpdateAsync(values);


        }
    }
}
