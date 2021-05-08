using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using Business.Constants;


namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Rental rental1 = new Rental
            //    {CarId = 1, CustomerId = 1, RentalId = 1, RentDate = new DateTime(2021, 02, 28)};
            //var result = rentalManager.Add(rental1);
            //Console.WriteLine(result.Message);
            //UserManager userManager = new UserManager(new EfUserDal());
            //User user1 = new User
            //{
            //    Email = "user@gmail.com", FirstName = "Süleyman", LastName = "Başbuğ", Password = "94390243", UserId = 1
            //};
            //var result = userManager.Add(user1);
            
            //var result = carManager.GetCarDetails();

            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.CarId + " / " + car.BrandName);

            //    }
            //    Console.WriteLine(result.Message);
            //}


            //var result= carManager.Add(new Car
            // {
            //     CarId = 5,
            //     ColorId = 2,
            //     BrandId = 4,
            //     ModelYear = 1971,
            //     DailyPrice = 40,
            //     Description = "manuel"
            // });
            //Console.WriteLine(result.Message);


            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarId + car.BrandName + car.ColorName);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Car Id:" + car.CarId + "\nBrand Id :" + car.BrandId + "\nColor Id :" + car.ColorId +
            //                      "\nCar Daily Price :" + car.DailyPrice + "\nDescription :" + car.Description + "\n**********");
            //}


            //foreach (var car in carManager.GetCarsByBrandId(5))
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}


            //foreach (var car in carManager.GetCarsByColorId(3))
            //{
            //    Console.WriteLine("Car Id :" + car.CarId + " --> " + "Brand Id:" + car.BrandId);
            //}


            //Console.WriteLine("\n");



            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //foreach (var brand in brandManager.GetAll().Data)
            //{
            //    Console.WriteLine(brand.BrandName);
            //}




            //Console.WriteLine("\n");


            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var brand in colorManager.GetAll().Data)
            //{
            //    Console.WriteLine(brand.ColorName);
            //}


            //Console.ReadKey();
        }
    }
}
