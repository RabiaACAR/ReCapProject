using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=1000,ModelYear=1992,Description="Passat" },
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=2000,ModelYear=1998,Description="Fiat" },
                new Car{Id=3,BrandId=2,ColorId=4,DailyPrice=3000,ModelYear=2000,Description="BMW" },
                new Car{Id=4,BrandId=5,ColorId=3,DailyPrice=8000,ModelYear=2010,Description="Skoda" },
                new Car{Id=5,BrandId=3,ColorId=2,DailyPrice=10000,ModelYear=2020,Description="Mikra" },
            };
        }




        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

       

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        

        public List<Car> GetById(int id)
        {
            return _cars.Where(x => x.Id == id).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == entity.Id);
            entity.Id = carToUpdate.Id;
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.Description = entity.Description;
        }

        
        
    }
}
