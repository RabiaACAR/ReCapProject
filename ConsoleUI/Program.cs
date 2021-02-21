using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            CarTest(carManager);

           
        }

        public static void CarTest(CarManager carManager)
        {
            //Car car = new Car { BrandId = 1, ColorId = 2, DailyPrice = 1000, Description = "Araba", ModelYear = 2021 };
            //carManager.Add(car);





            //var result = carManager.GetCarsByColorId(2);

            //    if (result.Success == true)
            //    {
            //        foreach (var car in result.Data)
            //        {
            //            Console.WriteLine(car.Description  + "/" + car.ModelYear);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            var result = carManager.GetCarsByColorId(2);
            foreach (var car in result.Data)
            {
                    Console.WriteLine(car.ColorId+ "/" + car.Description);

            }
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

        }
        }


}


