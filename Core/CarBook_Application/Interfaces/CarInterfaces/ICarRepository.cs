using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarListWithBrands();
        List<Car> GetLast5CarsWithBrands();
        List<CarPricing> GetCarsWithPricings();
    }
}
