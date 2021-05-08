using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailWithImage:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
    }
}
