using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public CarDetailDto GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            return GetCarsDetails(filter).FirstOrDefault();
        }
        public List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapProjectContext reCapContext = new ReCapProjectContext())
            {
                var result = from c in reCapContext.Cars
                    join b in reCapContext.Brands
                        on c.BrandId equals b.BrandId
                    join cl in reCapContext.Colors
                        on c.ColorId equals cl.ColorId
                    join g in reCapContext.Gears
                        on c.GearId equals g.GearId
                    join f in reCapContext.Fuels
                        on c.FuelId equals f.FuelId
                    select new CarDetailDto
                    {
                        CarId = c.CarId,
                        BrandId = b.BrandId,
                        BrandName = b.BrandName,
                        ColorId = cl.ColorId,
                        ColorName = cl.ColorName,
                        GearId = c.GearId,
                        GearName = g.GearName,
                        FuelId = c.FuelId,
                        FuelName = f.FuelName,
                        CarName = c.CarName,
                        DailyPrice = c.DailyPrice,
                        ModelYear = c.ModelYear,
                        ImagePath = (from carImages in reCapContext.CarImages
                            where carImages.CarId == c.CarId
                            select carImages.ImagePath).ToList(),
                        CarImage = (from img in reCapContext.CarImages
                            where (c.CarId == img.CarId)
                            select new CarImage
                            {
                                CarImageId = img.CarImageId,
                                CarId = c.CarId,
                                Date = img.Date,
                                ImagePath = img.ImagePath
                            }).ToList()
                    };
                return filter != null ? result.Where(filter).ToList() : result.ToList();
            }
        }

        public List<CarDetailDto> GetDtoByBrandId(int brandId)
        {
            return GetCarsDetails(b => b.BrandId == brandId);
        }

        public List<CarDetailDto> GetDtoByColorId(int colorId)
        {
            return GetCarsDetails(b => b.ColorId == colorId);
        }


    }
}
