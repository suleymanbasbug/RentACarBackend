using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager:ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage, IFormFile formFile)
        {
            var result = BusinessRules.Run(CheckCarImageCount(carImage.CarId));

            var imageResult = FileHelper.Add(formFile);
            if (!imageResult.Success)
            {
                return new ErrorResult();
            }

            carImage.ImagePath = imageResult.Message;
            carImage.Date=DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult("Resim Eklendi");

        }

        public IResult Delete(CarImage carImage)
        {
            var deletedCarImage = _carImageDal.Get(c => c.CarId == carImage.CarId);
            if (carImage==null)
            {
                return new ErrorResult("Resim Bulunamadı");

            }

            FileHelper.Delete(deletedCarImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }


        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage carImage, IFormFile formFile)
        {
            var isImage = _carImageDal.Get(c => c.CarId == carImage.CarId);
            if (isImage==null)
            {
                return new ErrorResult();
            }

            var updatedImage = FileHelper.Update(carImage.ImagePath, formFile);
            if (!updatedImage.Success)
            {
                return new ErrorResult();
            }

            carImage.ImagePath = updatedImage.Message;
            _carImageDal.Update(carImage);

            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<CarImage>>(result);
            }

            List<CarImage> images = new List<CarImage>();
            images.Add(new CarImage() { CarId = carId, CarImageId = 0, ImagePath = "/images/default.jpg" });

            return new SuccessDataResult<List<CarImage>>(images);
        }

        private IResult CheckCarImageCount(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count>4)
            {
                return new ErrorResult(Messages.ImageCount);
            }

            return new SuccessResult();
        }
    }
}
