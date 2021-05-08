using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters;
using Core.Entities;

namespace Entities.Concrete
{
    public class Fuel:IEntity
    {
        public int FuelId { get; set;}
        public string FuelName { get; set; }
    }
}
