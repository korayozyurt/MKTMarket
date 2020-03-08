using MKTMarket.Northwind.Bussines.Abstract;
using MKTMarket.Northwind.DataAccess.Abstract;
using MKTMarket.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKTMarket.Northwind.Bussines.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategorytDal _categoryDal;

        public CategoryManager(ICategorytDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
