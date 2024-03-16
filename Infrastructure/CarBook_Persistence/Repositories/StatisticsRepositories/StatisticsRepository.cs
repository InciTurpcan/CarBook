﻿using CarBook_Application.Interfaces.StatisticsInterfaces;
using CarBook_Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Persistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;

        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            var values = _context.Comments.GroupBy(x => x.BlogID).
                             Select(y => new
                             {
                                 BlogID = y.Key,
                                 Count = y.Count()
                             }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string blogName = _context.Blogs.Where(x => x.BlogID == values.BlogID).Select(y => y.Title).FirstOrDefault();
            return blogName;
        }

        public string GetBrandNameByMaxCar()
        {
            var values=_context.Cars.GroupBy(x => x.BrandID).
                                     Select(y=> new 
                                     {
                                         BrandId=y.Key, Count=y.Count()
                                     }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault();
            string brandName= _context.Brands.Where(x=>x.BrandID==values.BrandId).Select(y=>y.Name).FirstOrDefault();
            return brandName;
        }

        public int GetAuthorCount()
        {
            var value =_context.Authors.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            int id = _context.Pricings.Where(y => y.Name =="Günlük").Select(z=>z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w=>w.PricingID==id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMountly()
        {
            int id = _context.Pricings.Where(y => y.Name == "Aylık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            int id = _context.Pricings.Where(y => y.Name == "Haftalık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();  
            return value;
        }

        public int GetBrandCount()
        {
            var value =_context.Brands.Count();
            return value;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            int pricingId=_context.Pricings.Where(x=>x.Name== "Günlük").Select(y=>y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y=>y.PricingID==pricingId).Max(x => x.Amount);
            int carId =_context.CarPricings.Where(x=>x.Amount==amount).Select(y=>y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carId).Include(y => y.Brand).Select(z => z.Brand.Name + "" + z.Model).FirstOrDefault();
            return brandModel;
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            int pricingId = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingID == pricingId).Min(x => x.Amount);
            int carId = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carId).Include(y => y.Brand).Select(z => z.Brand.Name + "" + z.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
           var value =_context.Cars.Count();
            return value;
        }

        public int GetCarCountByKmSmallerThen1000()
        {
            var value = _context.Cars.Where(x=>x.Km<=1000).Count();
            return value;
        }

        public int GetCarCountByElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektirikli").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value =_context.Cars.Where(x=>x.Fuel=="Benzin" || x.Fuel=="Dizel").Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value =_context.Cars.Where(x=>x.Transmission=="Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }
    }
}
