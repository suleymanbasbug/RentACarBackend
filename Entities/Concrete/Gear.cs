using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Gear:IEntity
    {
        public int GearId { get; set; }
        public string GearName { get; set; }
    }
}
