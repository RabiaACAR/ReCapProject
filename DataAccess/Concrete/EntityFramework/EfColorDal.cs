
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Color'a ait özellikler buraya yazılacaktır.
    public class EfColorDal : EfEntityRepositoryBase<Color, DbCarContext>, IColorDal
    {
    }
}
