using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCreditCardDal:EfEntityRepositoryBase<CreditCard,ReCapProjectContext>,ICreditCardDal
    {
        public CreditCardDto GetCardByCustomerId(int customerId)
        {
            return GetCardsDetails(c => c.CustomerId == customerId).OrderBy(c => c.Id).LastOrDefault();
        }

        public CreditCardDto GetCardDetails(Expression<Func<CreditCardDto, bool>> filter = null)
        {
            return GetCardsDetails(filter).FirstOrDefault();
        }

        public List<CreditCardDto> GetCardsDetails(Expression<Func<CreditCardDto, bool>> filter = null)
        {
            using (ReCapProjectContext reCapContext = new ReCapProjectContext())
            {
                var result = from creditCard in reCapContext.CreditCard
                    join creditCardType in reCapContext.CreditCardType
                        on creditCard.CardTypeId equals creditCardType.Id
                    select new CreditCardDto
                    {
                        Id = creditCard.Id,
                        CustomerId = creditCard.CustomerId,
                        CardTypeId = creditCard.CardTypeId,
                        CardTypeName = creditCardType.TypeName,
                        CardNumber = creditCard.CardNumber,
                        FirstName = creditCard.FirstName,
                        LastName = creditCard.LastName,
                        ExpirationMonth = creditCard.ExpirationMonth,
                        ExpirationYear = creditCard.ExpirationYear,
                        Cvv = creditCard.Cvv
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
