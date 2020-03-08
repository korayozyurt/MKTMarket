using MKTMarket.Core.DataAccess.EntityFramework;
using MKTMarket.Northwind.DataAccess.Abstract;
using MKTMarket.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKTMarket.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
