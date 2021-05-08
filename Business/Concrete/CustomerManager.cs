﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }

        public DataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public DataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.CustomerId==customerId));
        }
        public IDataResult<List<CustomerDetailDto>> GetCustomersDetail()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomersDetail());
        }
    }
}
