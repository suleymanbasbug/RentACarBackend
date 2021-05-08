using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,ReCapProjectContext>,ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomersDetail()
        {
            using (ReCapProjectContext reCapContext = new ReCapProjectContext())
            {
                var result = from c in reCapContext.Customers
                    join u in reCapContext.Users
                        on c.UserId equals u.UserId
                    select new CustomerDetailDto
                    {
                        CustomerId = c.CustomerId,
                        CompanyName = c.CompanyName,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        UserId = c.UserId
                    };
                return result.ToList();
            }
        }
    }
}
