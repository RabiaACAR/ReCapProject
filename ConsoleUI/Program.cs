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
            //CarTest(carManager);

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Description + "/" + car.BrandName+"/"+car.ColorName + "/" +car.DailyPrice );
            }
        }

        //private static void CarTest(CarManager carManager)
        //{
        //    Car car = new Car { BrandId = 1, ColorId = 2, DailyPrice = 1000, Description = "Araba", ModelYear = 2021 };
        //    carManager.Add(car);

        //    foreach (var car1 in carManager.GetCarsByColorId(2))
        //    {
        //        Console.WriteLine(car1.Id);
        //    }
        //}
        


}
}

