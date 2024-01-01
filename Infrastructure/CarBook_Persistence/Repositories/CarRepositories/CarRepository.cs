using CarBook_Application.Interfaces.CarInterfaces;
using CarBook_Domain.Entities;
using CarBook_Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Car> GetCarListWithBrands()
        {
          var values = _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }
}
