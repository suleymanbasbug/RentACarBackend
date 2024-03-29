﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DateAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        List<CustomerDetailDto> GetCustomersDetail();
    }
}
