using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string ModelYear { get; set; }
        public string CarName { get; set; }
        public decimal DailyPrice { get; set; }
        public int GearId { get; set; }
        public string GearName { get; set; }
        public int FuelId { get; set; }
        public string FuelName { get; set; }
        public List<string> ImagePath { get; set; }
        public List<CarImage> CarImage { get; set; }

    }
}
