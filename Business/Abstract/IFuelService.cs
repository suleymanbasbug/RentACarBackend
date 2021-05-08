using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFuelService
    {
        IResult Add(Fuel fuel);
        IResult Delete(Fuel fuel);
        IResult Update(Fuel fuel);
        IDataResult<List<Fuel>> GetAll();
        IDataResult<Fuel> GetById(int fuelId);
    }
}
