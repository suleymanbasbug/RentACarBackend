using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                return new ErrorResult("Araç Halen Kirada");
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult();
            }
            
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId));
        }

        
        public IResult GetRentalsCar(Rental rental)
        {
            if (rental.RentDate > rental.ReturnDate) return new ErrorResult("Teslim tarihi alış tarihinden küçük olamaz.");
            var result = _rentalDal.GetRentalDetails(r => r.CarId == rental.CarId).
                Where(r =>
                    ((r.RentDate == rental.RentDate) && (r.ReturnDate == rental.ReturnDate)) ||
                    ((rental.RentDate >= r.RentDate) && (rental.RentDate <= r.ReturnDate)) ||
                    ((rental.ReturnDate >= r.RentDate) && (rental.ReturnDate <= r.ReturnDate))).ToList();

            if (result.Count > 0)
            {
                string errorMessage = "seçilen tarihler arasında araç zaten kiralanmış.";
                return new ErrorResult(errorMessage);
            }
            return new SuccessResult("seçilen tarihler arasında araç kiralanabilir.");
        }
    }
}
