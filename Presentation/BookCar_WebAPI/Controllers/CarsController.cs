﻿using CarBook_Application.Features.CQRS.Commands.CarCommands;
using CarBook_Application.Features.CQRS.Handlers.CarHandlers;
using CarBook_Application.Features.CQRS.Queries.CarQueries;
using CarBook_Application.Features.CQRS.Results.CarResults;
using CarBook_Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookCar_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
        private readonly GetLast5CarWithBrandQueryHandler _getLast5CarWithBrandQueryHandler;

        
        public CarsController(GetCarByIdQueryHandler getCarByIdQueryHandler,
            GetCarQueryHandler getCarQueryHandler,
            CreateCarCommandHandler createCarCommandHandler,
            UpdateCarCommandHandler updateCarCommandHandler,
            RemoveCarCommandHandler removeCarCommandHandler,
            GetCarWithBrandQueryHandler getCarWithBrandQueryHandler,
            GetLast5CarWithBrandQueryHandler getLast5CarWithBrandQueryHandler)
            
        {
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _getCarQueryHandler = getCarQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
            _getLast5CarWithBrandQueryHandler = getLast5CarWithBrandQueryHandler;
           
        }



        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok("Araba Bilgisi Eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("Araba Bilgisi Sililindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Araba Bilgisi Güncellendi.");
        }

        [HttpGet("GetCarWithBrand")]
        public IActionResult GetCarWithBrand()
        {
            var value =  _getCarWithBrandQueryHandler.Handle();
            return Ok(value);
        }

        [HttpGet("GetLast5CarWithBrandQueryHandler")]
        public IActionResult GetLast5CarWithBrandQueryHandler()
        {
            var values = _getLast5CarWithBrandQueryHandler.Handle();
            return Ok(values);
        }


    }
}
