using MKTMarket.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace MKTMarket.Northwind.Bussines.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
