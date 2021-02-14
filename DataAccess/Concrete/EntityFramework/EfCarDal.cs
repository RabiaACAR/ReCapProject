using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    //Car'a ait özel metotlar buraya yazılacaktır.
    public class EfCarDal : EfEntityRepositoryBase<Car, DbCarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (DbCarContext context = new DbCarContext())
            {
                var results = from c in context.Cars join b in context.Brands
                    on c.BrandId equals b.Id
                              join co in context.Colors
                    on c.ColorId equals co.Id
                              select new CarDetailsDto
                              {

                                  DailyPrice = c.DailyPrice,
                                  BrandName = b.Name,
                                  ColorName = co.Name,
                                  Description = c.Description
                              };
                            return results.ToList();
            }
        }



    }
}
