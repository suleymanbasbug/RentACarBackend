using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        DataResult<List<Customer>> GetAll();
        DataResult<Customer> GetById(int customerId);
        IDataResult<List<CustomerDetailDto>> GetCustomersDetail();

    }
}
