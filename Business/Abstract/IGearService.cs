using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IGearService
    {
        IResult Add(Gear gear);
        IResult Delete(Gear gear);
        IResult Update(Gear gear);
        IDataResult<List<Gear>> GetAll();
        IDataResult<Gear> GetById(int gearId);
    }
}
