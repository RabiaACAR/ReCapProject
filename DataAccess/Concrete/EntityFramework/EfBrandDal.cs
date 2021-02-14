using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Brand'a ait özel metotlar buraya yazılacaktır
    public class EfBrandDal : EfEntityRepositoryBase<Brand, DbCarContext>, IBrandDal
    {
      
    }
}

