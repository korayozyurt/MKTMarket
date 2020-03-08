﻿using MKTMarket.Northwind.Bussines.Abstract;
using MKTMarket.Northwind.DataAccess.Abstract;
using MKTMarket.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKTMarket.Northwind.Bussines.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

    }
}
