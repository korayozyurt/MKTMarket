using MKTMarket.Core.DataAccess;
using MKTMarket.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKTMarket.Northwind.DataAccess.Abstract {
    public interface IProductDal:IEntityRepository<Product> {
    }
}
