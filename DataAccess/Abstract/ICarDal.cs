using Core.DateAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        CarDetailDto GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null);
        List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null);
        List<CarDetailDto> GetDtoByBrandId(int brandId);
        List<CarDetailDto> GetDtoByColorId(int colorId);
    }
}
